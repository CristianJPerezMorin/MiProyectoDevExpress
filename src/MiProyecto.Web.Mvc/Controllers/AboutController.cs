using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MiProyecto.Controllers;
using MiProyecto.Web.Reports;

namespace MiProyecto.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MiProyectoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Editor()
        {
            return View();
        }
    }
}
