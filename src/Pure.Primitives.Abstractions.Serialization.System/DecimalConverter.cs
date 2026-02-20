using System.Text.Json;
using System.Text.Json.Serialization;
using Decimal = Pure.Primitives.Number.Decimal;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class DecimalConverter : JsonConverter<Number.INumber<decimal>>
{
    public override Number.INumber<decimal> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Decimal(reader.GetDecimal());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<decimal> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
