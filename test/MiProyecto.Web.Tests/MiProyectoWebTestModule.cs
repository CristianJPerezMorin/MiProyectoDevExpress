using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MiProyecto.EntityFrameworkCore;
using MiProyecto.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MiProyecto.Web.Tests
{
    [DependsOn(
        typeof(MiProyectoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MiProyectoWebTestModule : AbpModule
    {
        public MiProyectoWebTestModule(MiProyectoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MiProyectoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MiProyectoWebMvcModule).Assembly);
        }
    }
}