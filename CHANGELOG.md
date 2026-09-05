# Changelog

All notable changes to Pure.Primitives.Abstractions.Serialization.System are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.0.1.3] — 2026-06-25

- Maintenance release: dependency and build updates.

---

## [0.1.0-preview.0.1.2] — 2026-05-20

- Maintenance release: dependency and build updates.

---

## [0.1.0-preview.0.1.1] — 2026-05-07

- Maintenance release: dependency and build updates.

---

## [0.1.0-preview.0.1.0] — 2026-02-20

### Added
- Initial release: `System.Text.Json` converters for the Pure.Primitives
  abstraction types — `BoolConverter`, `CharConverter`, `DateConverter`,
  `DateTimeConverter`, `DayOfWeekConverter`, `DecimalConverter`,
  `DoubleConverter`, `FloatConverter`, `GuidConverter`, `IntConverter`,
  `LongConverter`, `ShortConverter`, `StringConverter`, `TimeConverter`,
  `UIntConverter`, `ULongConverter`, `UShortConverter`.
- **`PrimitiveConverters`** — an `IEnumerable<JsonConverter>` bundling all
  converters for easy registration with `JsonSerializerOptions`.
