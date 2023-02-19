//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using OnlineExaminationSystem.Areas.Admin.Service;
//using OnlineExaminationSystem.Common.Constant;
//using OnlineExaminationSystem.Common.Model;
//using OnlineExaminationSystem.Common.Model.DTO;
//using OnlineExaminationSystem.Data;

//namespace OnlineExaminationSystem.Controllers
//{
//    [Area(ViewResources.Admin)]
//    [Authorize]
//    public class ManageUserController : Controller
//    {
//        private readonly IManageUserService _service;

//        public ManageUserController(IManageUserService service)
//        {
//            _service = service;
//        }

//        // GET: ManageUser
//        public IActionResult Index()
//        {
//            return View(_service.GetAllUsers());
//        }

//        // GET: ManageUser/Details/5
//        public async Task<IActionResult> Details(string id)
//        {
//            var user =  await _service.GetUser(id);

//            if(user == null)
//            {
//                return NotFound();
//            }

//            return View(user);
//        }

//        // GET: ManageUser/Create
//        public IActionResult Create()
//        {
//            return View();
//        }

//        // POST: ManageUser/Create
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("Email,Password,Roles")] UserModel userModel)
//        {

//            await _service.CreateUser(userModel);
//            return RedirectToAction(nameof(Index));
            
//        }

//        //GET: ManageUser/Edit/5
//        public async Task<IActionResult> Edit(string id)
//        {
//            if (id == null )
//            {
//                return NotFound();
//            }

//            var userModel = await _service.GetUser(id);
//            if (userModel == null)
//            {
//                return NotFound();
//            }
//            return View(userModel);
//        }

//        // POST: ManageUser/Edit/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to.
//        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(string id, [Bind("FirstName,LastName,Email,PhoneNumber,Roles")] UserDTO user)
//        {

//            try
//            {
//                await _service.UpdateUser(id, user);
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                return View(user);

//            }
//            return RedirectToAction(nameof(Index));
//        }

//        // GET: ManageUser/Delete/5
//        public async Task<Result> Delete(string id)
//        {
//            if (id == null)
//            {
//                return new Result("Id not found");
//            }

//            var user = await _service.DeleteUser(id);

//            if (user == null)
//            {
//                return new Result("User not found");
//            }

//            return Result.Success;

//        }

//        //// POST: ManageUser/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public async Task<IActionResult> DeleteConfirmed(string id)
//        //{
//        //    if (_context.UserModel == null)
//        //    {
//        //        return Problem("Entity set 'ApplicationDbContext.UserModel'  is null.");
//        //    }
//        //    var userModel = await _context.UserModel.FindAsync(id);
//        //    if (userModel != null)
//        //    {
//        //        _context.UserModel.Remove(userModel);
//        //    }

//        //    await _context.SaveChangesAsync();
//        //    return RedirectToAction(nameof(Index));
//        //}

//        //private bool UserModelExists(string id)
//        //{
//        //    return _context.UserModel.Any(e => e.Id == id);
//        //}
//    }
//}