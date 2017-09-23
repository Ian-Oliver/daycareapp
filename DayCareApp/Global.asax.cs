using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DayCareApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HRLD5C6\SQLEXPRESS;Initial Catalog=DayCare;Integrated Security=True");
            conn.Open();
            SqlCommand command = new SqlCommand("Select * from Employees", conn);
            var reader = command.ExecuteReader();

            conn.Close();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
