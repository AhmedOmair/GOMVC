using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoMVC.Startup))]
namespace GoMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
