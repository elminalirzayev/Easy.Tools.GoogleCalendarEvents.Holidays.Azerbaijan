using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Enum;
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Service;
using System;


//var service = new HolidayService("YOUR_API_KEY");
var service = new HolidayService("AIzaSyBbAJaPVtNCk9ioDk8IjOJgb2hIk6D3AYY");

var holidays = await service.GetHolidaysAsync(CalendarLanguage.Turkish);

foreach (var item in holidays)
{
    Console.WriteLine(item);
}


