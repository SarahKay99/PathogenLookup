using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PathogenLookup.Startup))]
namespace PathogenLookup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
