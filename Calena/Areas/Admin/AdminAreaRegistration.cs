using System.Web.Mvc;

namespace Calena.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new {Controller = "home", action = "Index", id = UrlParameter.Optional },
                new[] {"Calena.Areas.Admin.Controllers" }
            );
        }
    }
}