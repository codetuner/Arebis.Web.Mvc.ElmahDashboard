using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Models.Logs
{
    public class PrevNextRequest
    {
        public int Sequence { get; set; }

        public String Application { get; set; }

        public String Host { get; set; }

        public String Source { get; set; }

        public String Type { get; set; }

        public String Search { get; set; }
    }
}