using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MiProyecto.Authorization;

namespace MiProyecto
{
    [DependsOn(
        typeof(MiProyectoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MiProyectoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MiProyectoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MiProyectoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
