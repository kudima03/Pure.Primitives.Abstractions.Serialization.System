using System.Collections;
using System.Text.Json.Serialization;

namespace Pure.Primitives.Abstractions.Serialization.System;

public sealed record PrimitiveConverters : IEnumerable<JsonConverter>
{
    public IEnumerator<JsonConverter> GetEnumerator()
    {
        yield return new BoolConverter();
        yield return new CharConverter();
        yield return new DateConverter();
        yield return new DateTimeConverter();
        yield return new DayOfWeekConverter();
        yield return new DecimalConverter();
        yield return new DoubleConverter();
        yield return new FloatConverter();
        yield return new GuidConverter();
        yield return new IntConverter();
        yield return new LongConverter();
        yield return new ShortConverter();
        yield return new StringConverter();
        yield return new TimeConverter();
        yield return new UIntConverter();
        yield return new ULongConverter();
        yield return new UShortConverter();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
