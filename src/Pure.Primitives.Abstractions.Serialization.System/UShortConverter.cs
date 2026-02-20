using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class UShortConverter : JsonConverter<Number.INumber<ushort>>
{
    public override Number.INumber<ushort> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new UShort(reader.GetUInt16());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<ushort> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
