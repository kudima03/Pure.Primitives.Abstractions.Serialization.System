using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class FloatConverter : JsonConverter<Number.INumber<float>>
{
    public override Number.INumber<float> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Float(reader.GetSingle());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<float> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
