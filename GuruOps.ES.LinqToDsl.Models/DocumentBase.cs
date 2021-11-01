using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using GuruOps.ES.LinqToDsl.Models.Attributes;

namespace GuruOps.ES.LinqToDsl.Models
{
    [Serializable]
    public abstract class DocumentBase : IDocument
    {
        protected DocumentBase(string documentType)
        {
            DocumentType = documentType;
            Id = Guid.NewGuid().ToString();
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }

        [NotMapped]
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [NotMapped]
        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        [Key]
        [Required]
        [NotMapped]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [NotMapped]
        [JsonPropertyName("modified")]
        public DateTime Modified { get; set; }

        [Required]
        [SwaggerExclude]
        [NotMapped]
        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }
    }
}