﻿using System.Web.Mvc;
using System.Web.Routing;

namespace RestAPI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        //public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        //{
        //    filters.Add(new HandleErrorAttribute());
        //}

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "GenerateToolPath", // Route name
                "{ToolPath}/{Generate}/{stlData}", // URL with parameters
                new { controller = "ToolPath", action = "Generate", stlData = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            //RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            StructureMap.ObjectFactory.Initialize(x =>
            {
                x.AddRegistry(new DependencyRegistry());
                x.AddRegistry(new UI.DependencyRegistry());
                x.AddRegistry(new Service.DependencyRegistry());
            });
        }
    }
}