using System.Web.Mvc;

namespace ElmahDashboardHostingApp.Areas.MvcElmahDashboard
{
    public class MvcElmahDashboardAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MvcElmahDashboard";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name: "MvcElmahDashboard_default",
                url: "MvcElmahDashboard/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ElmahDashboardHostingApp.Areas.MvcElmahDashboard.Controllers" }
            );
        }
    }
}