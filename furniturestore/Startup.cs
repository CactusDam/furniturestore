using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(furniturestore.Startup))]
namespace furniturestore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
