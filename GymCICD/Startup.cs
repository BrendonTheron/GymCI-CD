using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymCICD.Startup))]
namespace GymCICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
