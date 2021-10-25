using System.Text.Json.Serialization;

namespace LinqToDsl.Models
{
    public class OrderItem
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("sortOrder")]
        public int SortOrder { get; set; }
    }
}
