using Microsoft.AspNetCore.Mvc;

namespace OnlineExaminationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
