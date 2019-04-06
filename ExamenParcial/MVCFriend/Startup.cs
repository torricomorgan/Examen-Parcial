using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFriend.Startup))]
namespace MVCFriend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
