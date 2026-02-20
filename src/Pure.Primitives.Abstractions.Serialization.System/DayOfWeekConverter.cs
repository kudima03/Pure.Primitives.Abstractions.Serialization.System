using System.Text.Json;
using System.Text.Json.Serialization;
using Pure.Primitives.Abstractions.DayOfWeek;
using Pure.Primitives.DayOfWeek;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed class DayOfWeekConverter : JsonConverter<IDayOfWeek>
{
    public override IDayOfWeek Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        string str = reader.GetString()!;

        return str switch
        {
            "Monday" => new Monday(),
            "Tuesday" => new Tuesday(),
            "Wednesday" => new Wednesday(),
            "Thursday" => new Thursday(),
            "Friday" => new Friday(),
            "Saturday" => new Saturday(),
            "Sunday" => new Sunday(),
            _ => throw new JsonException("Unknown value"),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        IDayOfWeek value,
        JsonSerializerOptions options
    )
    {
        string res = value.DayNumberValue.NumberValue switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => throw new JsonException(),
        };

        writer.WriteStringValue(res);
    }
}
