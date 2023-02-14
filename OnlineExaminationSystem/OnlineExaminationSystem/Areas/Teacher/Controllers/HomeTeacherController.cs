using Microsoft.AspNetCore.Mvc;

namespace OnlineExaminationSystem.Areas.Teacher.Controllers
{
    [Area("Teacher")]
    public class HomeTeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
