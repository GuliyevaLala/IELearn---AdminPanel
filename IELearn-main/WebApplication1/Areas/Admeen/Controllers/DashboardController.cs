using Microsoft.AspNetCore.Mvc;

namespace IELearn.Areas.Admeen.Controllers {

    public class DashboardController : Controller {

        [Area("Admeen")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
