using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranMinhChien_Web_lab456.Startup))]
namespace TranMinhChien_Web_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
