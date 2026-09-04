using System.Text.Json.Serialization;

namespace GuildForm.Models;

public class Petitioner
{
    public int Id { get; set; }
    
    [JsonPropertyName("fullName")]
    public string FullName { get; set; } = string.Empty;
    
    [JsonPropertyName("lineage")]
    public string Lineage { get; set; } = string.Empty;
    
    [JsonPropertyName("sponsoringMaster")]
    public string SponsoringMaster { get; set; } = string.Empty;
    
    [JsonPropertyName("townOrBorough")]
    public string TownOrBorough { get; set; } = string.Empty;
    
    [JsonPropertyName("selectedGuildId")]
    public GuildId SelectedGuildId { get; set; }
    
    [JsonPropertyName("stationSought")]
    public string StationSought { get; set; } = string.Empty;
    
    [JsonPropertyName("sovereignTithes")]
    public decimal SovereignTithes { get; set; }
    
    [JsonPropertyName("winterPracticeYears")]
    public int WinterPracticeYears { get; set; }
    
    [JsonPropertyName("craftTestimony")]
    public string CraftTestimony { get; set; } = string.Empty;
    
    [JsonPropertyName("customOath")]
    public string CustomOath { get; set; } = string.Empty;
    
    [JsonPropertyName("oathAccepted")]
    public bool OathAccepted { get; set; }
    
    [JsonPropertyName("submissionDate")]
    public DateTime SubmissionDate { get; set; }
    
    [JsonPropertyName("registrationCode")]
    public string RegistrationCode { get; set; } = string.Empty;
    
    [JsonPropertyName("status")]
    public string Status { get; set; } = "Under Guild Scrutiny";
    
    // For certificate generation
    [JsonPropertyName("generatedSignature")]
    public string GeneratedSignature { get; set; } = string.Empty;
    
    [JsonPropertyName("lordChancellorSignature")]
    public string LordChancellorSignature { get; set; } = "Magnus Penumbra";
}