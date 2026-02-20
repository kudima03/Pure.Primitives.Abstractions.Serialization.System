using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.String;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class StringConverter : JsonConverter<IString>
{
    public override IString Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Primitives.String.String(reader.GetString()!);
    }

    public override void Write(
        Utf8JsonWriter writer,
        IString value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(value.TextValue);
    }
}
