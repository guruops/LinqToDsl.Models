using System.Text.Json.Serialization;

namespace LinqToDsl.Models
{
    public interface IExternalId
    {
        [JsonPropertyName("externalId")]
        string ExternalId { get; set; }
    }
}
