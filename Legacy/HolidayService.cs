using Easy.Tools.GoogleCalendarEvents.Models;
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Services;
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Enums;
using Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Enum;
using System.Net.Http;

namespace Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan.Service
{

    [Obsolete("This class is deprecated. Please use 'AzerbaijanHolidaysService' instead.")]
    public class HolidayService
    {
        private readonly AzerbaijanHolidaysService _newService;

        public HolidayService(string apiKey, System.Net.Http.HttpClient? httpClient = null)
        {
            _newService = new AzerbaijanHolidaysService(apiKey, httpClient);
        }

        public async Task<IReadOnlyList<Item>> GetHolidaysAsync(CalendarLanguage language = CalendarLanguage.Azerbaijani, CancellationToken cancellationToken = default)
        {
            var newLang = language == CalendarLanguage.English ? HolidayLanguage.English : HolidayLanguage.Azerbaijani;
            return await _newService.GetHolidaysAsync(newLang, cancellationToken);
        }
    }
}