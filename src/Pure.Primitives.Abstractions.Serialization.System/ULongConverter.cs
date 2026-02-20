using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class ULongConverter : JsonConverter<Number.INumber<ulong>>
{
    public override Number.INumber<ulong> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new ULong(reader.GetUInt64());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<ulong> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
