using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FilmLabShop.Models.db;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmLabShop.Models.db;

namespace Shopping.Controllers
{
    public class TbProductsController : Controller
    {
        private readonly FilmLabDbContext _context;

        public TbProductsController(FilmLabDbContext context)
        {
            _context = context;
        }

        // GET: TbProducts
        public async Task<IActionResult> Index()
        {
            TempData.Keep();
            var nav = 2;
            ViewBag.nav = nav;

            if (TempData["UserName"] != null)
            {
                var shoppingContext = _context.TbProducts.Include(t => t.Cate);
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

        // GET: TbProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbProduct = await _context.TbProducts
                .Include(t => t.Cate)
                .FirstOrDefaultAsync(m => m.PdId == id);
            if (tbProduct == null)
            {
                return NotFound();
            }

            return View(tbProduct);
        }

        // GET: TbProducts/Create
        public IActionResult Create()
        {
            TempData.Keep();
            var nav = 2;
            ViewBag.nav = nav;

            if (TempData["UserName"] != null)
            {
                ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
                TempData.Keep();
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Admin");
            }

        }

        // POST: TbProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PdId,PdImg,PdName,PdPrice,PdStock,PdStatus,CateId,PdDetail,PdSubHead,PdDelete")] TbProduct tbProduct, List<IFormFile> PdImg)
        {
            TempData.Keep();

            if (ModelState.IsValid)
            {
                foreach (var item in PdImg)
                {
                    if (item.Length > 0)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await item.CopyToAsync(stream);
                            tbProduct.PdImg = stream.ToArray();
                        }
                    }
                }

                _context.Add(tbProduct);
                await _context.SaveChangesAsync();
                TempData.Keep();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName", tbProduct.CateId);
            TempData.Keep();
            return View(tbProduct);
        }

        // GET: TbProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            TempData.Keep();
            var nav = 2;
            ViewBag.nav = nav;

            if (TempData["UserName"] != null)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var tbProduct = await _context.TbProducts.FindAsync(id);
                if (tbProduct == null)
                {
                    return NotFound();
                }
                ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName", tbProduct.CateId);
                TempData.Keep();
                return View(tbProduct);
            }
            else
            {
                TempData.Keep();
                return RedirectToAction("Index", "Admin");
            }

        }

        // POST: TbProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PdId,PdImg,PdName,PdPrice,PdStock,PdStatus,CateId,PdDetail,PdSubHead,PdDelete")] TbProduct tbProduct, List<IFormFile> PdImg)
        {
            if (id != tbProduct.PdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var item in PdImg)
                    {
                        if (item.Length > 0)
                        {
                            using (var stream = new MemoryStream())
                            {
                                await item.CopyToAsync(stream);
                                tbProduct.PdImg = stream.ToArray();
                            }
                        }
                    }

                    _context.Update(tbProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TbProductExists(tbProduct.PdId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData.Keep();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName", tbProduct.CateId);
            TempData.Keep();
            return View(tbProduct);
        }

        // GET: TbProducts/Delete/5
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

                var tbProduct = await _context.TbProducts
                    .Include(t => t.Cate)
                    .FirstOrDefaultAsync(m => m.PdId == id);
                if (tbProduct == null)
                {
                    TempData.Keep();
                    return NotFound();
                }
                TempData.Keep();
                return View(tbProduct);
            }
            else
            {
                TempData.Keep();
                return RedirectToAction("Index", "Admin");
            }

        }

        // POST: TbProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            TempData.Keep();
            var tbProduct = await _context.TbProducts.FindAsync(id);
            _context.TbProducts.Remove(tbProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TbProductExists(int id)
        {
            return _context.TbProducts.Any(e => e.PdId == id);
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
                    return View("Index", _context.TbProducts.ToList());

                }
                else
                {
                    TempData.Keep();
                    return View("Index", _context.TbProducts.Where(p => p.PdName.Contains(query)).ToList());
                }
            }
        }
    }
}