using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SELab55555.Startup))]
namespace SELab55555
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
