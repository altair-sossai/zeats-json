using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zeats.Json;

public static class JsonSerializer
{
    public static T Deserialize<T>(string json, JsonSerializerOptions options = null)
    {
        return System.Text.Json.JsonSerializer.Deserialize<T>(json, options ?? JsonConfiguration.Options);
    }

    public static async Task<T> DeserializeAsync<T>(Stream stream, JsonSerializerOptions options = null)
    {
        return await System.Text.Json.JsonSerializer.DeserializeAsync<T>(stream, options ?? JsonConfiguration.Options);
    }
}