using System.Text.Json.Serialization;

namespace LinqToDsl.Models
{
    public interface IDefault
    {
        [JsonPropertyName("isDefault")]
        bool IsDefault { get; set; }
    }
}
