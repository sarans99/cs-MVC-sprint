using System.Globalization;
using System.Text.Json.Serialization;

namespace cs_MVC_sprint.Models
{
    public class Author
    {
        [JsonPropertyName("Id")]
        public int Id {get; set;}
        [JsonPropertyName("Name")]
        public string? Name { get; set; }
        [JsonPropertyName("Nationality")]
        public string? Nationality { get; set; }

    }
}