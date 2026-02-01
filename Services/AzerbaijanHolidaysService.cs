using Easy.Tools.GoogleCalendarEvents;
using System.Net.Http;

namespace Easy.Tools.GoogleCalendarEvents.Holidays.Azerbaijan
{
    /// <summary>
    /// Provides functionality to fetch official holidays for Azerbaijan from Google Calendar.
    /// </summary>
    public class AzerbaijanHolidaysService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        // Google Calendar IDs for Azerbaijan
        private const string CalendarIdAz = "az.az#holiday@group.v.calendar.google.com";
        private const string CalendarIdEn = "en-gb.az#holiday@group.v.calendar.google.com";
        private const string CalendarIdTr = "tr.az#holiday@group.v.calendar.google.com";
        private const string CalendarIdRu = "ru.az#holiday@group.v.calendar.google.com";

        /// <summary>
        /// Initializes a new instance of the <see cref="AzerbaijanHolidaysService"/> class.
        /// </summary>
        /// <param name="apiKey">Your Google Cloud Console API Key.</param>
        /// <param name="httpClient">Optional HttpClient for Dependency Injection.</param>
        public AzerbaijanHolidaysService(string apiKey, HttpClient? httpClient = null)
        {
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));
            _httpClient = httpClient ?? new HttpClient();
        }

        /// <summary>
        /// Fetches the list of holidays asynchronously.
        /// </summary>
        /// <param name="language">Language of the holiday names (Azerbaijani or English).</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        /// <returns>List of holiday items.</returns>
        public async Task<IReadOnlyList<GoogleCalendarEvent>> GetHolidaysAsync(HolidayLanguage language = HolidayLanguage.Azerbaijani, CancellationToken cancellationToken = default)
        {
            var calendarId = language switch
            {
                HolidayLanguage.English => CalendarIdEn,
                HolidayLanguage.Russian => CalendarIdRu,
                HolidayLanguage.Turkish => CalendarIdTr,
                HolidayLanguage.Azerbaijani => CalendarIdAz,
                _ => CalendarIdAz // Default Azerbaijani
            };

            var eventService = new GoogleEventService(_apiKey, calendarId, _httpClient);

            return await eventService.GetEventsAsync(cancellationToken);
        }
    }
}