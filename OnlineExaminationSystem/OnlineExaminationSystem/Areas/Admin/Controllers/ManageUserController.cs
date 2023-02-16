using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSystem.Areas.Admin.Service;
using OnlineExaminationSystem.Common.Constant;
using OnlineExaminationSystem.Common.Model;

namespace OnlineExaminationSystem.Areas.Admin.Controllers
{
    [Area(ViewResources.Admin)]
    public class ManageUserController : Controller
    {
        private readonly IManageUserService _userManage;

        public ManageUserController(IManageUserService userManage)
        {
            _userManage = userManage;
        }

        // GET: ManageUserController
        public ActionResult Index()
        {
            var users = _userManage.GetAllUsers();

            return View(users);
        }

        // GET: ManageUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] UserModel model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}