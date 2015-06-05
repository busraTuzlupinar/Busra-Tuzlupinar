using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(arkadaslar.Startup))]
namespace arkadaslar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
