// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
using System.Text.Json.Serialization;

namespace ClaseJson;
public class Personajes
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("role")]
        public string role { get; set; }

        [JsonPropertyName("lore")]
        public string lore { get; set; }

        [JsonPropertyName("abilities")]
        public List<string> abilities { get; set; }
    }