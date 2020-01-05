using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HTO.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HTO.Web.Mvc.Controllers
{
    public class EmployeeController : HTOControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}