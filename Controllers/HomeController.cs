using Microsoft.AspNetCore.Mvc;
using PhamThiThuyQuynh_241230831.Models;
using System.Diagnostics;

namespace PhamThiThuyQuynh_241230831.Controllers
{
    public class HomeController : Controller
    {
        private readonly QlnhaSachContext _db;
        public HomeController(QlnhaSachContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            var ds = _db.Saches.Where(s => s.Gia != null && s.Gia > 100).ToList();
            return View(ds);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult GetSachByTheLoai( int id)
        {
            var ds = _db.Saches.Where(s => s.MaTl == id).ToList();
            ViewBag.TieuDe = _db.TheLoais.Find(id)?.TenTl;
            return PartialView("PhamThiThuyQuynh_MainContent, ds");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
