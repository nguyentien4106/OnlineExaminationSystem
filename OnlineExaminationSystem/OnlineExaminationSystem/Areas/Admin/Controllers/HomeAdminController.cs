using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSystem.Enums;

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
