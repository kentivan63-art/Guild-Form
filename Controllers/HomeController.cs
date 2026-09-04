using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GuildForm.Models;
using System.Linq;
using System.Collections.Generic;

namespace GuildForm.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Petition");
    }

    public IActionResult Petition()
    {
        var guilds = GuildOrdersData.GetAllGuilds();
        ViewBag.Guilds = guilds;
        return View();
    }

    [HttpPost]
    public IActionResult Petition(Petitioner petitioner)
    {
        if (ModelState.IsValid)
        {
            // Generate registration code
            petitioner.RegistrationCode = GenerateRegistrationCode(petitioner.SelectedGuildId);
            petitioner.SubmissionDate = DateTime.Now;
            petitioner.Status = "Under Guild Scrutiny";
            
            // In a real application, this would save to a database
            // For now, we'll return the certificate view
            ViewBag.Guilds = GuildOrdersData.GetAllGuilds();
            ViewBag.SelectedGuild = GuildOrdersData.GetAllGuilds()
                .FirstOrDefault(g => g.Id == petitioner.SelectedGuildId);
            
            return View("Certificate", petitioner);
        }
        
        ViewBag.Guilds = GuildOrdersData.GetAllGuilds();
        return View(petitioner);
    }

    public IActionResult GuildRolls()
    {
        // In a real application, this would fetch from database
        // For now, return empty list
        var petitions = new List<Petitioner>();
        ViewBag.Guilds = GuildOrdersData.GetAllGuilds();
        return View(petitions);
    }

    public IActionResult Charter()
    {
        return View();
    }

    private string GenerateRegistrationCode(GuildId guildId)
    {
        // Generate a unique registration code like SIGIL-BLACKSMITHS-001
        var guildName = guildId.ToString().ToUpper();
        var random = new Random();
        var number = random.Next(1000, 9999);
        return $"SIGIL-{guildName}-{number}";
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
