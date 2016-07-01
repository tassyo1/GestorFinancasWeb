using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestorFinancasWeb.Startup))]
namespace GestorFinancasWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
