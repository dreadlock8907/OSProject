using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(modeling_SearchBanners.Startup))]
namespace modeling_SearchBanners
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
