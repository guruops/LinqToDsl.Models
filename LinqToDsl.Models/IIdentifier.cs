using System.Text.Json.Serialization;

namespace LinqToDsl.Models
{
    public interface IIdentifier
    {
        [JsonPropertyName("identifier")]
        string Identifier { get; set; }
    }
}
