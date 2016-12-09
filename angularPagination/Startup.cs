using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angularPagination.Startup))]
namespace angularPagination
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
