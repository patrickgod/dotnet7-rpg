using System.Text.Json.Serialization;
namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DbNames
    {
        ISO9000 = 1,
        RiskManagement = 2,
        Grc = 3
    } 
}
