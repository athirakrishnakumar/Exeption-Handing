using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Exeption_handling.Startup))]
namespace Exeption_handling
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
