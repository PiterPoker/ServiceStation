using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceStation.Startup))]
namespace ServiceStation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
