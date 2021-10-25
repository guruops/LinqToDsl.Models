using System.Text.Json.Serialization;

namespace LinqToDsl.Models
{
    public class CustomFieldValue
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}
