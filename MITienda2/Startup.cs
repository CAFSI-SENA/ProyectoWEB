using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MITienda2.Startup))]
namespace MITienda2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
