using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gridster.Startup))]
namespace Gridster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
