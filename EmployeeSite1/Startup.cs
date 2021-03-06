using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmployeeSite1.Startup))]
namespace EmployeeSite1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
