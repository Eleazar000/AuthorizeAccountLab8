using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthorizeAccountLab8.Startup))]
namespace AuthorizeAccountLab8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
