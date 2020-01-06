using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTO.Controllers;
using HTO.Employee;
using HTO.Employee.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HTO.Web.Mvc.Controllers
{
    public class EmployeeController : HTOControllerBase
    {
        private readonly BaseEmployeeAppService _employeeAppService;

        public EmployeeController(BaseEmployeeAppService employeeAppService)
        {
            _employeeAppService = employeeAppService;
        }
        public IActionResult Index()
        {
            return View(_employeeAppService.GetTableViewModels());
        }

        public IActionResult Manage(int id)
        {
            var model = _employeeAppService.GetViewModel(id);

            return View(model);
        }

        [HttpPost]
        public async System.Threading.Tasks.Task<IActionResult> Save(EmployeeManageDto model)
        {
            if (!ModelState.IsValid)
            {
                //დროპდაუნების ჩამატება თუ დამჭირდება
                //_employeeAppService.FillManageDtoWithInitialData(model);
                return View("Manage", model);
            }
            else
                _employeeAppService.Save(model);

            return RedirectToAction("index");
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _employeeAppService.Delete(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _employeeAppService.Dispose();

            base.Dispose(disposing);
        }

    }
}