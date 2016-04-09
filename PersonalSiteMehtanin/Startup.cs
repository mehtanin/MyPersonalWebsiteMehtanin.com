using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalSiteMehtanin.Startup))]
namespace PersonalSiteMehtanin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
