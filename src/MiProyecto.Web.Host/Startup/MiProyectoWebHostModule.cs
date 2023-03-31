using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MiProyecto.Configuration;

namespace MiProyecto.Web.Host.Startup
{
    [DependsOn(
       typeof(MiProyectoWebCoreModule))]
    public class MiProyectoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MiProyectoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MiProyectoWebHostModule).GetAssembly());
        }
    }
}
