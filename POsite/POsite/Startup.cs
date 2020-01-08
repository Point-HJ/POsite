using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POsite.Startup))]
namespace POsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
