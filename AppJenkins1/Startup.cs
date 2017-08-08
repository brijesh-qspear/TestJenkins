using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppJenkins1.Startup))]
namespace AppJenkins1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
