using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSite10.Startup))]
namespace WebSite10
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
