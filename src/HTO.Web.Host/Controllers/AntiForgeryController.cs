using Microsoft.AspNetCore.Antiforgery;
using HTO.Controllers;

namespace HTO.Web.Host.Controllers
{
    public class AntiForgeryController : HTOControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
