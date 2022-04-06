using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Book_Exchange_Website.Startup))]
namespace Book_Exchange_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
