using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DebateScheduler.Startup))]
namespace DebateScheduler
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
