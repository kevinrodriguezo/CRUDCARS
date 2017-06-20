using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mantenimientocarros.Startup))]
namespace Mantenimientocarros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
