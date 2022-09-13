using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TI.MORADA.SOL.ADMINISTRACAO.Startup))]
namespace TI.MORADA.SOL.ADMINISTRACAO
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
