using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(specsfor_sample_for_roger.Web.Startup))]
namespace specsfor_sample_for_roger.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
