using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FM.Startup))]
namespace FM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
