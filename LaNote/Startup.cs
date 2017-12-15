using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LaNote.Startup))]
namespace LaNote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
