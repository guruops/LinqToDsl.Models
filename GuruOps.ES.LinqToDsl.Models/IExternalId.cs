using System.Text.Json.Serialization;

namespace GuruOps.ES.LinqToDsl.Models
{
    public interface IExternalId
    {
        [JsonPropertyName("externalId")]
        string ExternalId { get; set; }
    }
}
