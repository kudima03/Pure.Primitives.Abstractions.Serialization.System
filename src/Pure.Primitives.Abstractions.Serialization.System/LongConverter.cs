using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class LongConverter : JsonConverter<Number.INumber<long>>
{
    public override Number.INumber<long> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Long(reader.GetInt64());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<long> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
