using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MiProyecto.Web.Views
{
    public abstract class MiProyectoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MiProyectoRazorPage()
        {
            LocalizationSourceName = MiProyectoConsts.LocalizationSourceName;
        }
    }
}
