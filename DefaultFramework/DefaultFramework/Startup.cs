using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DefaultFramework.Startup))]
namespace DefaultFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
