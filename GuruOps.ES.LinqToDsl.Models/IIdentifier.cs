using System.Text.Json.Serialization;

namespace GuruOps.ES.LinqToDsl.Models
{
    public interface IIdentifier
    {
        [JsonPropertyName("identifier")]
        string Identifier { get; set; }
    }
}
