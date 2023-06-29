namespace ClaseJson;
// Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
using System.Text.Json.Serialization;

public class Personajes
    {
        [JsonPropertyName("name")]
        public string? name { get; set; }

        [JsonPropertyName("role")]
        public string? role { get; set; }

        [JsonPropertyName("lore")]
        public string? lore { get; set; }

        [JsonPropertyName("abilities")]
    #pragma warning disable
        public List<string> abilities { get; set; }
    #pragma warning restore
    }



    public class HelperDeJson
    {

        public string AbrirArchivoTexto(string nombreArchivo)
        {
            string documento;
              using (var archivoOpen = new FileStream(nombreArchivo, FileMode.Open))
            {
                using (var strReader = new StreamReader(archivoOpen))
                {
                    documento = strReader.ReadToEnd();
                    archivoOpen.Close();
                }
            }


            return documento;
        }

    }