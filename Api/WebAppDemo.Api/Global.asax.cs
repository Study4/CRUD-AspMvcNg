using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using WebAppDemo.Api.App_Start;

namespace WebAppDemo.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AutoMapper
            AutoMapperConfig.Configure();
            //Web Api
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
