using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Value
{
    public static class CalendarMappings
    {
        public static readonly Dictionary<CalendarLanguage, string> CalendarIds = new()
    {
        { CalendarLanguage.Azerbaijani, "az-az.az#holiday@group.v.calendar.google.com" },
        { CalendarLanguage.English, "en-gb.az#holiday@group.v.calendar.google.com" },
        { CalendarLanguage.Turkish, "tr-tr.az#holiday@group.v.calendar.google.com" },
    };
    }
}
