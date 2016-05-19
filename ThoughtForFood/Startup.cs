using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ThoughtForFood.Startup))]
namespace ThoughtForFood
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
