# Pure.Primitives.Abstractions.Serialization.System

`System.Text.Json` converters for **Pure.Primitives** abstract types — serialize and deserialize `IBool`, `IChar`, `IString`, `INumber<T>`, `IGuid`, `IDate`, `ITime`, `IDateTime`, and `IDayOfWeek`.

[![.NET build & test](https://github.com/kudima03/Pure.Primitives.Abstractions.Serialization.System/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions.Serialization.System/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Primitives.Abstractions.Serialization.System/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions.Serialization.System/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Primitives.Abstractions.Serialization.System)](https://www.nuget.org/packages/Pure.Primitives.Abstractions.Serialization.System)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Primitives.Abstractions.Serialization.System` provides a `JsonConverter<T>` for every interface defined in [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions). Because the domain model exposes only interfaces, `System.Text.Json` cannot resolve concrete implementations at deserialization time — these converters handle that mapping explicitly, reading and writing via the concrete types from [`Pure.Primitives`](https://github.com/kudima03/Pure.Primitives).

## Converters

| Converter | Interface | JSON representation |
|-----------|-----------|---------------------|
| `BoolConverter` | `IBool` | JSON boolean |
| `CharConverter` | `IChar` | Single-character JSON string |
| `StringConverter` | `IString` | JSON string |
| `IntConverter` | `INumber<int>` | JSON number |
| `LongConverter` | `INumber<long>` | JSON number |
| `ShortConverter` | `INumber<short>` | JSON number |
| `UIntConverter` | `INumber<uint>` | JSON number |
| `ULongConverter` | `INumber<ulong>` | JSON number |
| `UShortConverter` | `INumber<ushort>` | JSON number |
| `FloatConverter` | `INumber<float>` | JSON number |
| `DoubleConverter` | `INumber<double>` | JSON number |
| `DecimalConverter` | `INumber<decimal>` | JSON number |
| `GuidConverter` | `IGuid` | JSON string (UUID format) |
| `DateConverter` | `IDate` | JSON string (date format) |
| `TimeConverter` | `ITime` | JSON string (time format) |
| `DateTimeConverter` | `IDateTime` | JSON string (date-time format) |
| `DayOfWeekConverter` | `IDayOfWeek` | JSON number |

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) — Pure primitive interfaces
- [`Pure.Primitives`](https://github.com/kudima03/Pure.Primitives) — concrete implementations used during deserialization
