[![Build & Test](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/build.yml/badge.svg)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/build.yml)
[![Build & Release](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/release.yml/badge.svg)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/release.yml)
[![Build & Nuget Publish](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/nuget.yml/badge.svg)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/actions/workflows/nuget.yml)
[![Release](https://img.shields.io/github/v/release/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/releases)
[![License](https://img.shields.io/github/license/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan)](https://github.com/elminalirzayev/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan/blob/master/LICENSE.txt)
[![NuGet](https://img.shields.io/nuget/v/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.svg)](https://www.nuget.org/packages/Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan)


# Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan

This package allows you to retrieve public holiday events from [Google Public Calendars](https://developers.google.com/calendar) for Azerbaijan.

It uses Google Calendar API (v3) and provides a clean interface for fetching holiday data based on language preference.

It builds on top of the core [`Easy.Tools.GoogleCalendarEvents`](https://www.nuget.org/packages/Easy.Tools.GoogleCalendarEvents) package, which handles low-level interaction with the Google Calendar API.


---

## Installation

Install via NuGet:

dotnet add package Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan


---

## Requirements

* Google API Key (with Calendar API enabled)
* Internet access for fetching calendar data

---

## Usage

### Fetch Azerbaijan Holidays


var service = new HolidayService("YOUR_GOOGLE_API_KEY");
var holidays = await service.GetHolidaysAsync(CalendarLanguage.Azerbaijani);

foreach (var item in holidays)
{
    Console.WriteLine(item);
}


---

## Language Support

Supported calendar languages:

* `CalendarLanguage.Azerbaijani` → `az-az.azerbaijan#holiday@group.v.calendar.google.com`
* `CalendarLanguage.Turkish` → `tr-tr.azerbaijan#holiday@group.v.calendar.google.com`
* `CalendarLanguage.English` → `en-gb.azerbaijan#holiday@group.v.calendar.google.com`

---

## Notes

* Calendar IDs are internally mapped using `CalendarLanguage` enum.
* API key is injected via constructor and never exposed.
* Uses `HttpClient` internally – override or inject your own instance if needed.

---

## License

MIT

---

© 2025 Elmin Alirzayev / Easy Code Tools
