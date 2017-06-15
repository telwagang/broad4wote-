using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Broadband4Wote.Startup))]
namespace Broadband4Wote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
