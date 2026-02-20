using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.Date;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class DateConverter : JsonConverter<IDate>
{
    public override IDate Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return new Primitives.Date.Date(DateOnly.FromDateTime(reader.GetDateTime()));
    }

    public override void Write(
        Utf8JsonWriter writer,
        IDate value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            new DateOnly(
                value.Year.NumberValue,
                value.Month.NumberValue,
                value.Day.NumberValue
            ).ToString()
        );
    }
}
