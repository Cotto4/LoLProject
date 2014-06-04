using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoLProject.Startup))]
namespace LoLProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
