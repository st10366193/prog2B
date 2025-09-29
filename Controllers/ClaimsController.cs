using Microsoft.AspNetCore.Mvc;

namespace prog2B.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Create()//submit claim
        {
            return View();
        }
        public IActionResult Index()//lecturers claim list 
        {
            return View();
        }
        public IActionResult Review( int ID)// coordinator review page 
        {
            return View();
        }
    }
}
