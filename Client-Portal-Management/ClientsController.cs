using Microsoft.AspNetCore.Mvc;

namespace ClientPortalManagement.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
