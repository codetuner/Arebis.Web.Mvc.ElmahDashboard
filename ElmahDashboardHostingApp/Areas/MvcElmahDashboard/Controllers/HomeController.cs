using ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Code;
using ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Models.Home;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        private static ElmahErrorCounters EECounters = new ElmahErrorCounters(TimeSpan.FromDays(15));
        private static HeartBeatService HeartBeatService = new HeartBeatService();

        #region Infrastructure

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Apply culture:
            if (!String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["MvcElmahDashboardCulture"]))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["MvcElmahDashboardCulture"]);
            }

            base.OnActionExecuting(filterContext);
        }

        #endregion

        // GET: ElmahLog/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HourlyStats()
        {
            using (var context = new ElmahDashboardContext())
            {
                EECounters.UpdateCache(context);

                var now = DateTime.UtcNow;
                var model = new HourlyStatsModel();
                model.Timestamp = now;
                model.RangeEnd = now.TruncToHours().AddHours(1);
                model.RangeStart = model.RangeEnd.AddHours(-24);
                model.HourlyCounters = EECounters.GetHourlyCounters(model.RangeStart, model.RangeEnd);
                model.LastHourErrors = EECounters.GetErrors(now.AddHours(-1), now);
                model.SampleLogCount = Int32.Parse(ConfigurationManager.AppSettings["MvcElmahDashboardLogCount"].IfNullOrWhiteSpace("3"));
                foreach (var app in EECounters.GetErrors(now.AddHours(-4), now).Select(i => i.Application).Distinct())
                {
                    var appvar = app;
                    model.AppHourlyCounters[appvar] = EECounters.GetHourlyCounters(model.RangeEnd.AddHours(-4), model.RangeEnd, item => item.Application == appvar);
                }

                return View(model);
            }
        }
        
        public ActionResult DailyStats()
        {
            using (var context = new ElmahDashboardContext())
            {
                EECounters.UpdateCache(context);

                var now = DateTime.UtcNow;
                var model = new DailyStatsModel();
                model.Timestamp = now;
                model.RangeEnd = now.TruncToDays().AddDays(1);
                model.RangeStart = model.RangeEnd.AddDays(-14);
                model.DailyCounters = EECounters.GetDailyCounters(model.RangeStart, model.RangeEnd);
                model.LastDayErrors = EECounters.GetErrors(now.AddDays(-1), now);
                model.SampleLogCount = Int32.Parse(ConfigurationManager.AppSettings["MvcElmahDashboardLogCount"].IfNullOrWhiteSpace("3"));
                foreach (var app in EECounters.GetErrors(now.AddDays(-4), now).Select(i => i.Application).Distinct())
                {
                    var appvar = app;
                    model.AppDailyCounters[appvar] = EECounters.GetDailyCounters(model.RangeEnd.AddDays(-4), model.RangeEnd, item => item.Application == appvar);
                }

                return View(model);
            }
        }

        public ActionResult Heartbeat()
        {
            Response.CacheControl = "no-cache";
            Response.AddHeader("Pragma", "no-cache"); 
            Response.Expires = -1;
            if (HeartBeatService.Beat())
                return new HttpStatusCodeResult(HttpStatusCode.OK, "Heartbeat succeeded");
            else
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, "Heartbeat failed");
        }

        /// <summary>
        /// Used to handle scripts and styles requests.
        /// </summary>
        protected override void HandleUnknownAction(string actionName)
        {
            this.View(actionName).ExecuteResult(this.ControllerContext);
        }
    }
}