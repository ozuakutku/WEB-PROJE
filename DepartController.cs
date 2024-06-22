using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Proje_1.Data;
using ASP.NET_Core_Proje_1.Models;
using System.Linq;

namespace ASP.NET_Core_Proje_1.Controllers
{
    public class DepartController : Controller
    {
        private readonly AppDbContext _context;

        public DepartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult PageDepartman()
        {
            var departList = _context.GorevDepartmans.ToList();
            return View(departList);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            _context.GorevDepartmans.Add(d);
            _context.SaveChanges();
            return RedirectToAction("PageDepartman");
        }

        public IActionResult SilDepartman(int ID)
        {
            var d = _context.GorevDepartmans.Find(ID);
            _context.GorevDepartmans.Remove(d);
            _context.SaveChanges();
            return RedirectToAction("PageDepartman");
        }

        [HttpGet]
        public IActionResult GuncelleDepartman(int ID)
        {
            var d = _context.GorevDepartmans.Find(ID);
            return View(d);
        }

        [HttpPost]
        public IActionResult GuncelleDepartman(departmanlar d)
        {
            var dep = _context.GorevDepartmans.Find(d.ID);
            dep.DepartmanAd = d.DepartmanAd;
            dep.Detay = d.Detay;
            _context.SaveChanges();
            return RedirectToAction("PageDepartman");
        }
    }
}
