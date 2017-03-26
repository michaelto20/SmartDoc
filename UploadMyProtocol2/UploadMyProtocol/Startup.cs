using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadMyProtocol.Startup))]
namespace UploadMyProtocol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
