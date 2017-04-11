using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(com.bitforce.lab4_clo.Startup))]
namespace com.bitforce.lab4_clo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
