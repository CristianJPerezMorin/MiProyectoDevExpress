using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MiProyecto.Controllers;

namespace MiProyecto.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MiProyectoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Prueba()
        {
            return View();
        }
    }
}
