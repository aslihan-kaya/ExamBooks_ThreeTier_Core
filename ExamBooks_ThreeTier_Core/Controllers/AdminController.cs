using Microsoft.AspNetCore.Mvc;

namespace ExamBooks_ThreeTier_Core.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
