using Microsoft.AspNetCore.Mvc;

namespace SistemasWeb2.Areas.Principal.Controllers
{
    [Area("Principal")]
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
