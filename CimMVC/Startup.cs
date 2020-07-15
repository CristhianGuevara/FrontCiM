using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CimMVC.Startup))]
namespace CimMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
