using System.Text.Json;

namespace Zeats.Json;

public static class JsonConfiguration
{
    public static readonly JsonSerializerOptions Options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        IgnoreNullValues = true
    };
}