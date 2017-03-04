using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hiophop.Startup))]
namespace hiophop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
