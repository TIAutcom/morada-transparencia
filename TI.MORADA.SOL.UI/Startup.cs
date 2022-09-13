using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TI.MORADA.SOL.UI.Startup))]
namespace TI.MORADA.SOL.UI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
