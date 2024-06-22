using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Proje_1.Data;
using System.Linq;

namespace ASP.NET_Core_Proje_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var departmanlarList = _context.GorevDepartmans.ToList();
            return View(departmanlarList);
        }
    }
}
