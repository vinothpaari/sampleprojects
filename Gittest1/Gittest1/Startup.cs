using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gittest1.Startup))]
namespace Gittest1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
