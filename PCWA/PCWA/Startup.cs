using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCWA.Startup))]
namespace PCWA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
