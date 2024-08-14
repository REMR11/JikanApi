using System.Text.Json;
using System.Text.Json.Serialization;


namespace JikanApiExample
{
  // Clase para deserializar la respuesta JSON
    public class TopAnimeResponse
    {
        [JsonPropertyName("data")]
        public Anime[]? Top { get; set; }
    }
}