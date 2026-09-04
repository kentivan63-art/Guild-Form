using System.Text.Json.Serialization;

namespace GuildForm.Models;

public class GuildOrder
{
    [JsonPropertyName("id")]
    public GuildId Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("subTitle")]
    public string SubTitle { get; set; } = string.Empty;
    
    [JsonPropertyName("motto")]
    public string Motto { get; set; } = string.Empty;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
    
    [JsonPropertyName("patronSaint")]
    public string PatronSaint { get; set; } = string.Empty;
    
    [JsonPropertyName("heraldicColor")]
    public string HeraldicColor { get; set; } = string.Empty;
    
    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = string.Empty;
    
    [JsonPropertyName("defaultOath")]
    public string DefaultOath { get; set; } = string.Empty;
    
    [JsonPropertyName("recommendedDues")]
    public decimal RecommendedDues { get; set; }
}

public enum GuildId
{
    Blacksmiths = 1,
    Apothecaries = 2,
    Cartographers = 3,
    Stonemasons = 4,
    Scribes = 5,
    Falconers = 6,
    Alchemists = 7
}

public static class GuildOrdersData
{
    public static List<GuildOrder> GetAllGuilds()
    {
        return new List<GuildOrder>
        {
            new GuildOrder
            {
                Id = GuildId.Blacksmiths,
                Name = "Blacksmiths & Armorers",
                SubTitle = "Ferro Ignique Firmatur",
                Motto = "Ferro Ignique Firmatur",
                Description = "Masters of iron and flame, shaping the tools of war and peace.",
                PatronSaint = "Saint Dunstan the Smelter",
                HeraldicColor = "#2b1810",
                IconName = "🔨",
                DefaultOath = "I swear to forge with honor, to temper steel with wisdom, and to never weaponize my craft against the innocent.",
                RecommendedDues = 15
            },
            new GuildOrder
            {
                Id = GuildId.Apothecaries,
                Name = "Apothecaries & Herbalists",
                SubTitle = "Materia Salutis",
                Motto = "Materia Salutis",
                Description = "Keepers of ancient remedies and masters of healing arts.",
                PatronSaint = "Saints Cosmas & Damian",
                HeraldicColor = "#4a5d23",
                IconName = "⚗️",
                DefaultOath = "I swear to heal the sick, to study nature's remedies, and to never brew poison in malice.",
                RecommendedDues = 12
            },
            new GuildOrder
            {
                Id = GuildId.Cartographers,
                Name = "Cartographers & Navigators",
                SubTitle = "Monstra viam in tenebris",
                Motto = "Monstra viam in tenebris",
                Description = "Charting the unknown realms and guiding travelers through darkness.",
                PatronSaint = "Saint Brendan the Navigator",
                HeraldicColor = "#1e3a5f",
                IconName = "🗺️",
                DefaultOath = "I swear to map truthfully, to guide the lost, and to share knowledge of the roads less traveled.",
                RecommendedDues = 18
            },
            new GuildOrder
            {
                Id = GuildId.Stonemasons,
                Name = "Free Stonemasons & Vault-Wrights",
                SubTitle = "Fundamentum in Solido",
                Motto = "Fundamentum in Solido",
                Description = "Builders of cathedrals, castles, and the foundations of civilization.",
                PatronSaint = "The Four Crowned Martyrs",
                HeraldicColor = "#5c5c5c",
                IconName = "🏛️",
                DefaultOath = "I swear to build with integrity, to honor the geometry of creation, and to construct structures that endure.",
                RecommendedDues = 20
            },
            new GuildOrder
            {
                Id = GuildId.Scribes,
                Name = "Scribes & Master Illuminators",
                SubTitle = "Littera Scripta Manet",
                Motto = "Littera Scripta Manet",
                Description = "Preservers of knowledge and illuminators of sacred texts.",
                PatronSaint = "Saint Jerome the Scholastic",
                HeraldicColor = "#1a1a6e",
                IconName = "📜",
                DefaultOath = "I swear to record faithfully, to illuminate truth, and to protect the written word from decay.",
                RecommendedDues = 10
            },
            new GuildOrder
            {
                Id = GuildId.Falconers,
                Name = "Falconers & Beastmasters",
                SubTitle = "Oculus Regis",
                Motto = "Oculus Regis",
                Description = "Masters of the hunt and guardians of the realm's creatures.",
                PatronSaint = "Saint Eustace the Huntsman",
                HeraldicColor = "#3d2914",
                IconName = "🦅",
                DefaultOath = "I swear to hunt with honor, to protect the creatures of the realm, and to never take sport in cruelty.",
                RecommendedDues = 14
            },
            new GuildOrder
            {
                Id = GuildId.Alchemists,
                Name = "Alchemists & Transmuters",
                SubTitle = "Aurum Nostrum Non Est Aurum Vulgi",
                Motto = "Aurum Nostrum Non Est Aurum Vulgi",
                Description = "Seekers of the philosopher's stone and transformers of matter.",
                PatronSaint = "Albertus Magnus the Sage",
                HeraldicColor = "#4a2810",
                IconName = "⚜️",
                DefaultOath = "I swear to seek wisdom over wealth, to respect the balance of nature, and to never misuse the sacred arts.",
                RecommendedDues = 25
            }
        };
    }
}