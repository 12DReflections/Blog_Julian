using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog_Julian.Startup))]
namespace Blog_Julian
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
