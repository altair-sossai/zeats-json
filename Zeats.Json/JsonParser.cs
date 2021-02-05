using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zeats.Json
{
    public static class JsonParser
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        public static T Deserialize<T>(string json, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize<T>(json, options ?? Options);
        }

        public static async Task<T> DeserializeAsync<T>(Stream stream, JsonSerializerOptions options = null)
        {
            return await JsonSerializer.DeserializeAsync<T>(stream, options ?? Options);
        }
    }
}