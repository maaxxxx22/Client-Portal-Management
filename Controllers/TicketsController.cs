using Microsoft.AspNetCore.Mvc;

namespace ClientPortalManagement.Controllers
{
    public class TicketsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
