using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class UIntConverter : JsonConverter<Number.INumber<uint>>
{
    public override Number.INumber<uint> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new UInt(reader.GetUInt32());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<uint> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
