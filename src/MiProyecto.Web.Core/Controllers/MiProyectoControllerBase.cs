using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MiProyecto.Controllers
{
    public abstract class MiProyectoControllerBase: AbpController
    {
        protected MiProyectoControllerBase()
        {
            LocalizationSourceName = MiProyectoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
