using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.Guid;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class GuidConverter : JsonConverter<IGuid>
{
    public override IGuid Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Primitives.Guid.Guid(global::System.Guid.Parse(reader.GetString()!));
    }

    public override void Write(
        Utf8JsonWriter writer,
        IGuid value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(value.GuidValue.ToString());
    }
}
