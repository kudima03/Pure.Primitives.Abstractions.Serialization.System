using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.Char;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class CharConverter : JsonConverter<IChar>
{
    public override IChar Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        string str = reader.GetString() ?? throw new JsonException();
        return str.Length != 1
            ? throw new JsonException()
            : new Primitives.Char.Char(str.First());
    }

    public override void Write(
        Utf8JsonWriter writer,
        IChar value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(value.CharValue.ToString());
    }
}
