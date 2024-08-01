using Microsoft.AspNetCore.Mvc;

namespace Marqueto2.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Cliente()
        {
            return View();
        }
    }
}
