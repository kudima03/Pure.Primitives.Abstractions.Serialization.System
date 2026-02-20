using System.Text.Json;
using System.Text.Json.Serialization;
using Double = Pure.Primitives.Number.Double;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class DoubleConverter : JsonConverter<Number.INumber<double>>
{
    public override Number.INumber<double> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Double(reader.GetDouble());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<double> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
