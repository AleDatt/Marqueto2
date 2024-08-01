using Microsoft.AspNetCore.Mvc;

namespace Marqueto2.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
