using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NoteMe.Startup))]
namespace NoteMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
