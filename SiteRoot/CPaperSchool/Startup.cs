using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CPaperSchool.Startup))]
namespace CPaperSchool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
