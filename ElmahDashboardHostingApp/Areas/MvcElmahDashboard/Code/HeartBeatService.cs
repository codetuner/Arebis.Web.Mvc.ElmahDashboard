using System;
using System.Configuration;
using System.Net;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Code
{
    public class HeartBeatService
    {
        public static HeartBeatService Default = new HeartBeatService();

        private DateTime LastBeatTime = DateTime.MinValue;

        private bool LastBeatResult = false;

        public HeartBeatService()
        {
            this.CheckUrl = ConfigurationManager.AppSettings["MvcElmahDashboardHeartBeatUrl"].IfNullOrWhiteSpace(null);
            this.CheckInterval = TimeSpan.Parse(ConfigurationManager.AppSettings["MvcElmahDashboardHeartBeatInterval"].IfNullOrWhiteSpace("00:01:00"));
            this.DirectFromBrowser = Boolean.Parse(ConfigurationManager.AppSettings["MvcElmahDashboardHeartBeatDirectFromBrowser"].IfNullOrWhiteSpace("false"));
        }

        public string CheckUrl { get; set; }

        public TimeSpan CheckInterval { get; set; }

        public bool DirectFromBrowser { get; set; }

        public bool IsMonitoring
        {
            get { return this.CheckUrl != null; }
        }

        public bool Beat()
        {
            lock (this)
            {
                // If less than half checkinterval ago beated, return last beat result:
                if (LastBeatTime.AddMilliseconds(CheckInterval.TotalMilliseconds * 0.5) > DateTime.UtcNow)
                {
                    return LastBeatResult;
                }

                // Perform beat:
                try
                {
                    LastBeatTime = DateTime.UtcNow;
                    var req = (HttpWebRequest)WebRequest.Create(CheckUrl);
                    req.Headers.Add(HttpRequestHeader.CacheControl, "no-cache");
                    req.Headers.Add(HttpRequestHeader.Pragma, "no-cache");
                    req.Timeout = 5000;
                    using (var resp = req.GetResponse())
                    {
                        return LastBeatResult = true;
                    }
                }
                catch
                {
                    return LastBeatResult = false;
                }
            }
        }
    }
}