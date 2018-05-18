using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HR.Web.Startup))]
namespace HR.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
