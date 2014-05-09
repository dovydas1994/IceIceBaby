using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IceSubs.Startup))]
namespace IceSubs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
