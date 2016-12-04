using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PollHub.Startup))]
namespace PollHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
