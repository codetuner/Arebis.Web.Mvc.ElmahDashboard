using System;
using System.Collections.Generic;
using System.Linq;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Code
{
    public class ElmahErrorCounters
    {
        public ElmahErrorCounters(TimeSpan maxCacheAge)
        {
            this.CachedItems = new List<ElmahErrorItem>();
            this.MaxCacheAge = maxCacheAge;
            this.LastCacheUpdateTime = DateTime.MinValue;
        }

        public TimeSpan MaxCacheAge { get; set; }

        public DateTime LastCacheUpdateTime { get; private set; }

        public List<ElmahErrorItem> CachedItems { get; private set; }

        public void UpdateCache(ElmahDashboardContext context)
        {
            // Skip cache updating if not older than 10 seconds:
            if (LastCacheUpdateTime.AddSeconds(10) > DateTime.Now) return;

            lock (this)
            {
                // Flush old items out of cache:
                var minDate = DateTime.UtcNow - MaxCacheAge;
                CachedItems.RemoveAll(i => i.TimeUtc < minDate);

                // Retrieve new items:
                var minSequence = CachedItems.Select(i => i.Sequence).DefaultIfEmpty(-1).Max();
                CachedItems.AddRange(context.ListErrorItems(minDate, minSequence));
            }
        }

        public int[] GetHourlyCounters(DateTime rangeStartHour, DateTime rangeEndHour)
        {
            return GetHourlyCounters(rangeStartHour, rangeEndHour, item => true);
        }

        public int[] GetHourlyCounters(DateTime rangeStartHour, DateTime rangeEndHour, Func<ElmahErrorItem, bool> where)
        {
            var result = new int[(int)(rangeEndHour.TruncToHours() - rangeStartHour.TruncToHours()).TotalHours];
            var items = CachedItems.Where(where).Where(i => i.TimeUtc >= rangeStartHour && i.TimeUtc <= rangeEndHour).ToList();
            foreach (var item in items)
            {
                result[(int)(item.TimeUtc - rangeStartHour).TotalHours]++;
            }

            return result;
        }

        public int[] GetDailyCounters(DateTime rangeStartDate, DateTime rangeEndDate)
        {
            return GetDailyCounters(rangeStartDate, rangeEndDate, item => true);
        }

        public int[] GetDailyCounters(DateTime rangeStartDate, DateTime rangeEndDate, Func<ElmahErrorItem, bool> where)
        {
            var result = new int[(int)(rangeEndDate.TruncToDays() - rangeStartDate.TruncToDays()).TotalDays];
            var items = CachedItems.Where(where).Where(i => i.TimeUtc >= rangeStartDate && i.TimeUtc <= rangeEndDate).ToList();
            foreach (var item in items)
            {
                result[(int)(item.TimeUtc - rangeStartDate).TotalDays]++;
            }

            return result;
        }

        public List<ElmahErrorItem> GetErrors(DateTime rangeStartHour, DateTime rangeEndHour)
        {
            return CachedItems.Where(i => i.TimeUtc >= rangeStartHour && i.TimeUtc <= rangeEndHour).ToList();
        }
    }
}