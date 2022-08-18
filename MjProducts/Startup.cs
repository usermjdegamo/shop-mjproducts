using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MjProducts.Startup))]
namespace MjProducts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
