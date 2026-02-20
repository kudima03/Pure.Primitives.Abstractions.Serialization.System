using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class ShortConverter : JsonConverter<Number.INumber<short>>
{
    public override Number.INumber<short> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Short(reader.GetInt16());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<short> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
