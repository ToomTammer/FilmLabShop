using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLabShop.Models.db;

namespace Shopping.Controllers
{
    public class TbBillsController : Controller
    {
        private readonly FilmLabDbContext _context;

        public TbBillsController(FilmLabDbContext context)
        {
            _context = context;
        }

        // GET: TbBills
        public async Task<IActionResult> Index()
        {
            TempData.Keep();
            var nav = 2;
            ViewBag.nav = nav;
            if (TempData["UserName"] != null)
            {
                var shoppingContext = _context.TbBills.Include(t => t.Cus).Include(t => t.Pd);
                TempData.Keep();
                return View(await shoppingContext.ToListAsync());
            }
            else
            {
                TempData.Keep();
                return RedirectToAction("Index", "Admin");
            }

        }

        public ActionResult Logout()
        {
            TempData.Clear();
            return RedirectToAction("Index", "Admin");
        }

        // GET: TbBills/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            TempData.Keep();
            var nav = 2;
            ViewBag.nav = nav;
            if (TempData["UserName"] != null)
            {
                if (id == null)
                {
                    TempData.Keep();
                    return NotFound();
                }

                var tbBill = await _context.TbBills
                    .Include(t => t.Cus)
                    .Include(t => t.Pd)
                    .FirstOrDefaultAsync(m => m.BillId == id);
                if (tbBill == null)
                {
                    TempData.Keep();
                    return NotFound();
                }
                TempData.Keep();
                return View(tbBill);
            }
            else
            {
                TempData.Keep();
                return RedirectToAction("Index", "Admin");
            }

        }

        // POST: TbBills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            TempData.Keep();
            var nav = 2;
            ViewBag.nav = nav;

            var tbBill = await _context.TbBills.FindAsync(id);
            _context.TbBills.Remove(tbBill);
            await _context.SaveChangesAsync();
            TempData.Keep();
            return RedirectToAction(nameof(Index));
        }

        private bool TbBillExists(int id)
        {
            return _context.TbBills.Any(e => e.BillId == id);
        }


        public IActionResult Searchbox(string query)
        {
            {

                TempData.Keep();
                var nav = 2;
                ViewBag.nav = nav;
                if (string.IsNullOrEmpty(query))
                {
                    TempData.Keep();
                    return View("Index", _context.TbBills.ToList());

                }
                else
                {
                    TempData.Keep();
                    return View("Index", _context.TbBills.Where(p => p.Cus.CusName.Contains(query)).ToList());
                }
            }
        }
    }
}