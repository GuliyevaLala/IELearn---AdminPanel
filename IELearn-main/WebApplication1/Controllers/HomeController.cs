using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using IELearn.Data;
using IELearn.Models;

namespace IELearn.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }


    }
}