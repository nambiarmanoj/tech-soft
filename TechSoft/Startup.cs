using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TechSoft.Startup))]
namespace TechSoft
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
