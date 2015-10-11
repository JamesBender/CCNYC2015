using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularContactDemo.Startup))]
namespace AngularContactDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
