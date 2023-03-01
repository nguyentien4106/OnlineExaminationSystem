using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSystem.Admin.Service;
using OnlineExaminationSystem.Admin.ViewModel.ManageCDIO;
using OnlineExaminationSystem.Common.Constant;
using OnlineExaminationSystem.Common.Model;

namespace OnlineExaminationSystem.Admin.Controllers
{
    [Area(ViewResources.Admin)]
    public class ManageCDIOController : Controller
    {
        private readonly IManageCDIOService _service;

        public ManageCDIOController(IManageCDIOService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var cdios = _service.GetAll();
            var model = new CDIOViewModel
            {
                CDIOs = cdios
            };

            return View(model);
        }

        public IActionResult Create()
        {
            var cdio = new CDIOViewModel();

            return View(cdio);
        }

        [HttpPost]
        public IActionResult Create(CDIOViewModel viewModel)
        {
            _service.AddCDIO(viewModel.CDIO);
            return Ok(new Result());
        }
    }
}