using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSystem.Areas.Admin.Service;
using OnlineExaminationSystem.Common.Model.DTO;

namespace OnlineExaminationSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ManageQuestionController : Controller
    {
        private readonly IManageQuestionService _service;

        public ManageQuestionController(IManageQuestionService service)
        {
            _service = service;
        }

        // GET: Admin/ManageQuestion
        public async Task<IActionResult> Index()
        {
            return View(await _service.GetAllQuestions());
        }

        //// GET: Admin/ManageQuestion/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null || _context.Question == null)
        //    {
        //        return NotFound();
        //    }

        //    var question = await _context.Question
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (question == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(question);
        //}

        //// GET: Admin/ManageQuestion/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: Admin/ManageQuestion/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Level,Code,Content,AnswerKey,Subject")] QuestionDTO question)
        {
            //if (ModelState.IsValid)
            //{
            //    question.Id = Guid.NewGuid();
            //    _context.Add(question);
            //    await _context.SaveChangesAsync();
            //    return RedirectToAction(nameof(Index));
            //}
            return View(question);
        }

        //// GET: Admin/ManageQuestion/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null || _context.Question == null)
        //    {
        //        return NotFound();
        //    }

        //    var question = await _context.Question.FindAsync(id);
        //    if (question == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(question);
        //}

        //// POST: Admin/ManageQuestion/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Id,Level,Code,Content,AnswerKey,Subject")] Question question)
        //{
        //    if (id != question.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(question);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!QuestionExists(question.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(question);
        //}

        //// GET: Admin/ManageQuestion/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null || _context.Question == null)
        //    {
        //        return NotFound();
        //    }

        //    var question = await _context.Question
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (question == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(question);
        //}

        //// POST: Admin/ManageQuestion/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    if (_context.Question == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.Question'  is null.");
        //    }
        //    var question = await _context.Question.FindAsync(id);
        //    if (question != null)
        //    {
        //        _context.Question.Remove(question);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool QuestionExists(Guid id)
        //{
        //  return _context.Question.Any(e => e.Id == id);
        //}
    }
}