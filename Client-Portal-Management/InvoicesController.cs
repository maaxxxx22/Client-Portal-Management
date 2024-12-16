using Microsoft.AspNetCore.Mvc;

namespace ClientPortalManagement.Controllers
{
    public class InvoicesController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
    }
}
