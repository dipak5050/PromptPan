using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RoughtConfig
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"employee",
                url:"employee",
                defaults: new {Controller="Employee",Action= "Employeeall" }
                ) ;

            routes.MapRoute(
                name: "emloyeebyid",
                url: "employee/{id}",
                defaults: new { Controller = "Employee", Action = "GetEmployee" }
                );

            routes.MapRoute(
                name:"employeeAdress",
                url:"employee/{id}/adress",
                defaults:new {Controller="Employee",Action="employeeadress" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
