using Microsoft.AspNetCore.Mvc;

namespace MyWebTest.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{code}")]
        public IActionResult HttpCodeHandler(int code)
        {
            switch (code)
            {
                case 404: return View("NotFound");
                default: break;
            }
            return View("Error");
        }
    }
}
