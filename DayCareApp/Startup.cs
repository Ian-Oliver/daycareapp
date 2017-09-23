using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DayCareApp.Startup))]
namespace DayCareApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
