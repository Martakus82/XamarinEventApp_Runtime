using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(XamarinEventAppService.Startup))]

namespace XamarinEventAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}