using System.Web.Mvc;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class SharedController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            this.View(actionName).ExecuteResult(this.ControllerContext);
        }
    }
}