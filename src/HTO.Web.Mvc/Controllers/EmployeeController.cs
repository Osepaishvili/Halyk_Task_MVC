using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTO.Controllers;
using HTO.Employee;
using Microsoft.AspNetCore.Mvc;

namespace HTO.Web.Mvc.Controllers
{
    public class EmployeeController : HTOControllerBase
    {
        private readonly BaseEmployeeAppService _baseEmployeeAppService;

        public EmployeeController(BaseEmployeeAppService baseEmployeeAppService)
        {
            _baseEmployeeAppService = baseEmployeeAppService;
        }
        public IActionResult Index()
        {
            _baseEmployeeAppService.Create();
            return View();
        }
    }
}