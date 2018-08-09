using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SIRF.Startup))]
namespace SIRF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
