using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web_test.Startup))]
namespace web_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
