using Microsoft.AspNetCore.Mvc;
using FilmLabShop.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilmLabShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly FilmLabDbContext _context;


        public AdminController(FilmLabDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            TempData.Keep();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(TbAdminstrator admin)
        {

            if (ModelState.IsValid)
            {
                using (FilmLabDbContext _context = new FilmLabDbContext())
                {
                    var obj = _context.TbAdminstrators.Where(a => a.AdminName.Equals(admin.AdminName) && a.AdminPw.Equals(admin.AdminPw)).FirstOrDefault();
                    if (obj != null)
                    {
                        TempData["UserName"] = obj.AdminName.ToString();
                        TempData.Keep();
                        return RedirectToAction("Index", "TbProducts");
                    }
                }
            }

            ViewBag.msg = "Invalid Username Or Password";

            return View(admin);
        }

        public ActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Index");
        }





    }
}
