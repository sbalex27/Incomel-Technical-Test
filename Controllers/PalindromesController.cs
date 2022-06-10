using Microsoft.AspNetCore.Mvc;

namespace Incomel_Technical_Test.Controllers
{
    public class PalindromesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
