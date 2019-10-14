using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula_MVC.Startup))]
namespace Aula_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
