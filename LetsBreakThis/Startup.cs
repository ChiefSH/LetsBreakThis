using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LetsBreakThis.Startup))]
namespace LetsBreakThis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
