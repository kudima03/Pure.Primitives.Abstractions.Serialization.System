using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.Bool;
using Pure.Primitives.Bool;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class BoolConverter : JsonConverter<IBool>
{
    public override IBool Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return reader.GetBoolean() ? new True() : new False();
    }

    public override void Write(
        Utf8JsonWriter writer,
        IBool value,
        JsonSerializerOptions options
    )
    {
        writer.WriteBooleanValue(value.BoolValue);
    }
}
