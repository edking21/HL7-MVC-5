using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HL7MVC5.Startup))]
namespace HL7MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
