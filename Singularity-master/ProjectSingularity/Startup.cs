using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectSingularity.Startup))]
namespace ProjectSingularity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
