using System;
using System.Text.Json.Serialization;

namespace GuruOps.ES.LinqToDsl.Models
{
    public interface IDocument
    {
        [JsonPropertyName("created")]
        DateTime Created { get; set; }

        [JsonPropertyName("deleted")]
        bool Deleted { get; set; }

        [JsonPropertyName("documentType")]
        string DocumentType { get; set; }

        [JsonPropertyName("id")]
        string Id { get; set; }

        [JsonPropertyName("modified")]
        DateTime Modified { get; set; }
    }
}