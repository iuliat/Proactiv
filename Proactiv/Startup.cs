using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Proactiv.Startup))]
namespace Proactiv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
