using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorViewsForAngularJS.Startup))]
namespace RazorViewsForAngularJS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
