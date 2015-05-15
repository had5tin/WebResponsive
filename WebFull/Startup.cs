using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFull.Startup))]
namespace WebFull
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
