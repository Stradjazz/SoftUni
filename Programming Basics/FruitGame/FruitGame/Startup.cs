using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FruitGame.Startup))]
namespace FruitGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
