using System.Text.Json.Serialization;

namespace GuruOps.ES.LinqToDsl.Models
{
    public interface IDefault
    {
        [JsonPropertyName("isDefault")]
        bool IsDefault { get; set; }
    }
}
