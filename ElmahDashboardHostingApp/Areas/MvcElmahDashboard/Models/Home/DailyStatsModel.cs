using System;
using System.Collections.Generic;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Models.Home
{
    public class DailyStatsModel
    {
        public DailyStatsModel()
        {
            this.AppDailyCounters = new Dictionary<string, int[]>();
        }

        public DateTime Timestamp { get; set; }

        public DateTime RangeStart { get; set; }

        public DateTime RangeEnd { get; set; }

        public int[] DailyCounters { get; set; }

        public List<Code.ElmahErrorItem> LastDayErrors { get; set; }

        public Dictionary<string, int[]> AppDailyCounters { get; set; }

        public int SampleLogCount { get; set; }
    }
}