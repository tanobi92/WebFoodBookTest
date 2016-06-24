using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFoodbook.Startup))]
namespace WebFoodbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
