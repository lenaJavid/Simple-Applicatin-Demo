using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyTestApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //To Secure All The Controls of the project to be Authenticate first
            //Notice the MVC controller authorize filter is from System.Web.Mvc while the ApiController authorize filter is from System.Web.Http.
            GlobalConfiguration.Configuration.Filters.Add(new System.Web.Http.AuthorizeAttribute());
            GlobalFilters.Filters.Add(new System.Web.Mvc.AuthorizeAttribute());

        }

        //void Application_AcquireRequestState(object sender, EventArgs e) 
        //{
        //}
    }
}
