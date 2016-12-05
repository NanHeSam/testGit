using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testGitMVC.Startup))]
namespace testGitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
