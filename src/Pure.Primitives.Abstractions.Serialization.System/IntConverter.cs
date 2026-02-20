using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Number;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class IntConverter : JsonConverter<Number.INumber<int>>
{
    public override Number.INumber<int> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Int(reader.GetInt32());
    }

    public override void Write(
        Utf8JsonWriter writer,
        Number.INumber<int> value,
        JsonSerializerOptions options
    )
    {
        writer.WriteNumberValue(value.NumberValue);
    }
}
