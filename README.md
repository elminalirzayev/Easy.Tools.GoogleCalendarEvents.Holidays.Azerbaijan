[![Build & Test](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/build.yml/badge.svg)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/build.yml)
[![Build & Release](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/release.yml/badge.svg)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/release.yml)
[![Build & Nuget Publish](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/nuget.yml/badge.svg)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/nuget.yml)
[![Release](https://img.shields.io/github/v/release/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/releases)
[![License](https://img.shields.io/github/license/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/blob/master/LICENSE.txt)
[![NuGet](https://img.shields.io/nuget/v/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.svg)](https://www.nuget.org/packages/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan)


# Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan

A dedicated .NET library for fetching **Official Public Holidays of Azerbaijan (Azərbaycan Rəsmi Bayramları)** directly from Google Calendar.

> This library is an extension of [Easy.Tools.GoogleCalendarEvents](https://www.nuget.org/packages/Easy.Tools.GoogleCalendarEvents).

## Features

- **Zero Configuration:** No need to hunt for Calendar IDs.
- **Multi-Language Support:** Fetch holiday names in **Azerbaijani** (default) or **English**.
- **Always Up-to-Date:** Uses Google's official holiday calendar data.
- **Strongly Typed:** Easy configuration using `HolidayLanguage` enum.
- **Backward Compatible:** Includes legacy support for older versions.

## Installation

```powershell
Install-Package Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan
```

Or via CLI:

```powershell
dotnet add package Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan
```

## Usage

### 1. Basic Usage (Azerbaijani Default)

By default, the service returns holiday names in Azerbaijani (e.g., "Novruz Bayramı").

```csharp
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Services;

var apiKey = "YOUR_GOOGLE_API_KEY";

// Initialize the service
var service = new AzerbaijanHolidaysService(apiKey);

// Fetch holidays
var holidays = await service.GetHolidaysAsync();

Console.WriteLine($"Found {holidays.Count} holidays:");
foreach (var h in holidays)
{
    Console.WriteLine($"- {h.Summary} ({h.Start.Date})");
}
// Output: "- Novruz Bayramı (2025-03-20)"
```

### 2. English Names Support

You can explicitly request holiday names in English (e.g., "Novruz Holiday").

```csharp
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Services;
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Enums;

var apiKey = "YOUR_GOOGLE_API_KEY";
var service = new AzerbaijanHolidaysService(apiKey);

// Fetch holidays in English
var holidays = await service.GetHolidaysAsync(HolidayLanguage.English);

foreach (var h in holidays)
{
    Console.WriteLine($"- {h.Summary} ({h.Start.Date})");
}
// Output: "- Novruz Holiday (2025-03-20)"
```

##  Migration Guide (v1.x -> v1.1+)

If you were using the older `HolidayService` class, **your code will still work** but you will see a deprecation warning.

-   **Old Class:** `HolidayService` (Marked as Obsolete)
    
-   **New Class:** `AzerbaijanHolidaysService`
    

We recommend updating your code to use `AzerbaijanHolidaysService` for better naming clarity and future support.


## 🇦🇿 Covered Holidays

Includes all official public holidays in Azerbaijan:

## Requirements

-   .NET 6.0+, .NET Standard 2.0+, or .NET Framework 4.7.2+
    
-   A valid Google API Key

-   Internet access for fetching calendar data


## License

This project is licensed under the MIT License.

---

© 2025 Elmin Alirzayev / Easy Code Tools


