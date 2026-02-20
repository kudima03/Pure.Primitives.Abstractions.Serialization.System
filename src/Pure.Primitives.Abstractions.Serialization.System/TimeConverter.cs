using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.Time;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class TimeConverter : JsonConverter<ITime>
{
    public override ITime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Primitives.Time.Time(TimeOnly.Parse(reader.GetString()!));
    }

    public override void Write(
        Utf8JsonWriter writer,
        ITime value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            new TimeOnly(
                value.Hour.NumberValue,
                value.Minute.NumberValue,
                value.Second.NumberValue,
                value.Millisecond.NumberValue,
                value.Microsecond.NumberValue
            ).ToString()
        );
    }
}
