using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xhub.Startup))]
namespace Xhub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
