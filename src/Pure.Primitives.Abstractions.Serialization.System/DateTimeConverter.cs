using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.DateTime;

namespace Pure.Primitives.Abstractions.Serialization.System;

using Date = Primitives.Date.Date;
using DateTime = Primitives.DateTime.DateTime;
using Time = Primitives.Time.Time;

public sealed class DateTimeConverter : JsonConverter<IDateTime>
{
    public override IDateTime Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        global::System.DateTime dateTime = reader.GetDateTime();

        Date date = new Date(DateOnly.FromDateTime(dateTime));
        Time time = new Time(TimeOnly.FromDateTime(dateTime));

        return new DateTime(date, time);
    }

    public override void Write(
        Utf8JsonWriter writer,
        IDateTime value,
        JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            new global::System.DateTime(
                value.Year.NumberValue,
                value.Month.NumberValue,
                value.Day.NumberValue,
                value.Hour.NumberValue,
                value.Minute.NumberValue,
                value.Second.NumberValue,
                value.Millisecond.NumberValue,
                value.Microsecond.NumberValue
            ).ToString()
        );
    }
}
