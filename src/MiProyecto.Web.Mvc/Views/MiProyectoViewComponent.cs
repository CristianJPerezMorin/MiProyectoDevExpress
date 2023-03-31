using Abp.AspNetCore.Mvc.ViewComponents;

namespace MiProyecto.Web.Views
{
    public abstract class MiProyectoViewComponent : AbpViewComponent
    {
        protected MiProyectoViewComponent()
        {
            LocalizationSourceName = MiProyectoConsts.LocalizationSourceName;
        }
    }
}
