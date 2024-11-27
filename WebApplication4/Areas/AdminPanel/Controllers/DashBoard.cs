using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Areas.AdminPanel.Controllers
{
    public class DashBoard : Controller
    {
        [Area("AdminPanel")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
