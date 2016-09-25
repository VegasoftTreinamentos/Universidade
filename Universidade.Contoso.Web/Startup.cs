using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Universidade.Contoso.Web.Startup))]
namespace Universidade.Contoso.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
