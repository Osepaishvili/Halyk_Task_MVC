using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using HTO.Controllers;

namespace HTO.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : HTOControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
