using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(librarium.Startup))]
namespace librarium
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
