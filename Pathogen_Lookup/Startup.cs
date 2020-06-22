using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pathogen_Lookup.Startup))]
namespace Pathogen_Lookup
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Is it possible to initialize the app with data by putting code here?
        }
    }
}
