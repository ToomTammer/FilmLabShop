using FilmLabShop.Models;
using FilmLabShop.Models.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;

namespace FilmLabShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmLabDbContext _context;

        List<CartItem> li = new List<CartItem>();

        public HomeController(FilmLabDbContext context)
        {
            _context = context;
        }



        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        //{
        //     _logger = logger;
        //}

        public async Task<IActionResult> IndexAsync()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Update Cart & Total
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }



            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            var shoppingContext = _context.TbProducts.Include(t => t.Cate);
            return View(await shoppingContext.ToListAsync());

            //var nav = 1;
            //ViewBag.nav = nav;
            //ViewBag.footer = nav;

            //if (TempData["cart"] != null)
            //{
            //    double? x = 0;

            //    ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
            //    List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
            //    foreach (var item in li2)
            //    {
            //        x += item.CartTotal;

            //    }

            //    String tt = JsonConvert.SerializeObject(x);
            //    String itemcu = JsonConvert.SerializeObject(li2.Count());
            //    TempData["total"] = tt;
            //    TempData["item_count"] = itemcu;
            //}
            //TempData.Keep();

            ////return View(_context.TbProduct.OrderByDescending(x => x.PdId).ToList());
            //var shoppingContext = _context.TbProduct.Include(t => t.Cate);
            //return View(await shoppingContext.ToListAsync());
        }


        public async Task<IActionResult> ProductCategoryAsync()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Update Cart & Total
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }



            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            var shoppingContext = _context.TbProducts.Include(t => t.Cate);
            return View(await shoppingContext.ToListAsync());

        }

        public async Task<IActionResult> ProductOlympusAsync()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Update Cart & Total
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }



            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            var shoppingContext = _context.TbProducts.Include(t => t.Cate);
            return View(await shoppingContext.ToListAsync()); ;
        }

        public async Task<IActionResult> ProductPentaxAsync()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Update Cart & Total
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }



            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            var shoppingContext = _context.TbProducts.Include(t => t.Cate);
            return View(await shoppingContext.ToListAsync());
        }

        public async Task<IActionResult> ProductOlympusLensAsync()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Update Cart & Total
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }



            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            var shoppingContext = _context.TbProducts.Include(t => t.Cate);
            return View(await shoppingContext.ToListAsync());
        }

        public async Task<IActionResult> ProductPentaxLensAsync()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Update Cart & Total
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }



            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            var shoppingContext = _context.TbProducts.Include(t => t.Cate);
            return View(await shoppingContext.ToListAsync());
        }



        public async Task<IActionResult> ProductDetailAsync(int? id, TbProduct ps)
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();

            ///Check id return
            if (id == null)
            {
                id = (int?)TempData["iddetail"];

            }

            ///Update Total & Cart
            if (TempData["cart"] != null)
            {
                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }
            ///Update Total & Cart End

            var tbProduct = await _context.TbProducts
                .Include(t => t.Cate)
                .FirstOrDefaultAsync(m => m.PdId == id);

            if (tbProduct == null)
            {

                return RedirectToAction("Index");
            }
            TempData.Keep();
            ViewData["CateId"] = new SelectList(_context.TbCategories, "CateId", "CateName");
            ViewData["PdName"] = new SelectList(_context.TbProducts, "PdId", "PdName");
            return View(tbProduct);

        }

        [HttpPost]
        //Add to Cart Detail
        public ActionResult Addtocart(TbProduct tbp, string qty, int Id)
        {
            TbProduct p = _context.TbProducts.Where(x => x.PdId == Id).SingleOrDefault();
            TempData["iddetail"] = p.PdId;

            CartItem c = new CartItem();
            c.CartId = p.PdId;
            c.CartPrice = (float)p.PdPrice;
            c.CartQty = Convert.ToInt32(qty);
            c.CartTotal = c.CartPrice * c.CartQty;
            c.CartName = p.PdName;
            c.CartDelete = p.PdDelete;
            c.CartStock = p.PdStock;
            //c.TbProduct = tbp;
            //c.CartImg = p.PdImg;


            if (TempData["cart"] == null)
            {

                li.Add(c);
                String srt = JsonConvert.SerializeObject(li);
                TempData["cart"] = srt;


            }
            else
            {
                li = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = li as List<CartItem>;
                int flag = 0;
                foreach (var item in li2)
                {
                    if (item.CartId == c.CartId)
                    {
                        item.CartQty += c.CartQty;
                        item.CartTotal += c.CartTotal;
                        flag = 1;

                    }

                }
                if (flag == 0)
                {
                    li2.Add(c);
                }

                String srt = JsonConvert.SerializeObject(li2);
                TempData["cart"] = srt;

            }

            TempData.Keep();




            return RedirectToAction("ProductDetail");
        }

        ///Add to cart Home
        public ActionResult Addtocart2(TbProduct tbp, string qty, int Id)
        {
            TbProduct p = _context.TbProducts.Where(x => x.PdId == Id).SingleOrDefault();
            TempData["iddetail"] = p.PdId;

            CartItem c = new CartItem();
            c.CartId = p.PdId;
            c.CartPrice = (float)p.PdPrice;
            c.CartQty = 1;
            c.CartTotal = c.CartPrice * c.CartQty;
            c.CartName = p.PdName;
            c.CartDelete = p.PdDelete;
            c.CartStock = p.PdStock;
            //c.TbProduct = tbp;
            //c.CartImg = p.PdImg;


            if (TempData["cart"] == null)
            {

                li.Add(c);
                String srt = JsonConvert.SerializeObject(li);
                TempData["cart"] = srt;


            }
            else
            {
                li = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = li as List<CartItem>;
                int flag = 0;
                foreach (var item in li2)
                {
                    if (item.CartId == c.CartId)
                    {
                        item.CartQty += 1;
                        item.CartTotal += c.CartTotal;
                        flag = 1;

                    }

                }
                if (flag == 0)
                {
                    li2.Add(c);
                }

                String srt = JsonConvert.SerializeObject(li2);
                TempData["cart"] = srt;

            }

            TempData.Keep();




            return RedirectToAction("Index");
        }

        ///Add to cart Category
        public ActionResult Addtocart3(TbProduct tbp, string qty, int Id)
        {
            TbProduct p = _context.TbProducts.Where(x => x.PdId == Id).SingleOrDefault();
            TempData["iddetail"] = p.PdId;

            CartItem c = new CartItem();
            c.CartId = p.PdId;
            c.CartPrice = (float)p.PdPrice;
            c.CartQty = 1;
            c.CartTotal = c.CartPrice * c.CartQty;
            c.CartName = p.PdName;
            c.CartDelete = p.PdDelete;
            c.CartStock = p.PdStock;
            //c.TbProduct = tbp;
            //c.CartImg = p.PdImg;


            if (TempData["cart"] == null)
            {

                li.Add(c);
                String srt = JsonConvert.SerializeObject(li);
                TempData["cart"] = srt;


            }
            else
            {
                li = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = li as List<CartItem>;
                int flag = 0;
                foreach (var item in li2)
                {
                    if (item.CartId == c.CartId)
                    {
                        item.CartQty += 1;
                        item.CartTotal += c.CartTotal;
                        flag = 1;

                    }

                }
                if (flag == 0)
                {
                    li2.Add(c);
                }

                String srt = JsonConvert.SerializeObject(li2);
                TempData["cart"] = srt;

            }

            TempData.Keep();




            return RedirectToAction("ProductCategory");
        }



        public IActionResult Privacy()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();
            return View();
        }

        public IActionResult EmptyCart()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();
            return View();
        }
        public IActionResult Cart(int? id, CartItem ct)
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();
            if (TempData["cart"] == null)
            {
                return RedirectToAction("EmptyCart");

            }

            ///Update Total & Cart
            if (TempData["cart"] != null)
            {

                double? x = 0;

                ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = ViewData["cart"] as List<CartItem>;
                foreach (var item in li2)
                {
                    x += item.CartTotal;

                }

                String tt = JsonConvert.SerializeObject(x);
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["total"] = tt;
                TempData["item_count"] = itemcu;
            }
            ///Update Total & Cart End
            ///
            ///Convert ViewData["cart"] and Return to view
            ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);

            double tto = (double)JsonConvert.DeserializeObject((string)TempData["total"]);

            double tt2 = tto;
            ViewBag.Total = string.Format("{0:n}", tt2);



            TempData.Keep();
            return View();

        }

        public IActionResult Minus(int? id)
        {
            var nav = 1;
            double? x = 0;
            ViewBag.nav = nav;
            ViewBag.footer = nav;

            TempData.Keep();
            li = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
            List<CartItem> li2 = li as List<CartItem>;
            CartItem c = li2.Where(x => x.CartId == id).SingleOrDefault();
            int flag = 0;
            foreach (var item in li2)
            {
                if (item.CartId == c.CartId)
                {
                    item.CartQty -= 1;
                    item.CartTotal -= c.CartPrice;
                    x = item.CartTotal;
                    flag = 1;


                }

            }

            if (c.CartQty == 0)
            {
                li2.Remove(c);
            }

            if (flag == 0)
            {
                li2.Add(c);
            }

            ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);

            String srt = JsonConvert.SerializeObject(li2);
            TempData["cart"] = srt;
            String itemcu = JsonConvert.SerializeObject(li2.Count());
            TempData["item_count"] = itemcu;
            String tt = JsonConvert.SerializeObject(x);
            TempData["total"] = tt;
            double tto = (double)JsonConvert.DeserializeObject((string)TempData["total"]);

            double tt2 = tto;
            ViewBag.Total = string.Format("{0:n}", tt2);


            TempData.Keep();
            return RedirectToAction("Cart");
            // return View("Cart");

        }

        public IActionResult Plus(int? id, string qty)
        {
            var nav = 1;
            double? x = 0;
            ViewBag.nav = nav;
            ViewBag.footer = nav;

            TempData.Keep();
            li = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
            List<CartItem> li2 = li as List<CartItem>;
            CartItem c = li2.Where(x => x.CartId == id).SingleOrDefault();
            int flag = 0;
            foreach (var item in li2)
            {

                if (item.CartId == c.CartId)
                {
                    item.CartQty += 1;
                    item.CartTotal += c.CartPrice;
                    x = item.CartTotal;
                    flag = 1;

                }

            }
            if (flag == 0)
            {
                li2.Add(c);
            }

            ViewData["cart"] = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
            String srt = JsonConvert.SerializeObject(li2);
            TempData["cart"] = srt;
            String itemcu = JsonConvert.SerializeObject(li2.Count());
            TempData["item_count"] = itemcu;
            String tt = JsonConvert.SerializeObject(x);
            TempData["total"] = tt;
            double tto = (double)JsonConvert.DeserializeObject((string)TempData["total"]);

            double tt2 = tto;
            ViewBag.Total = string.Format("{0:n}", tt2);


            TempData.Keep();
            return RedirectToAction("Cart");
            // return View("Cart");

        }

        // [HttpPost]
        public ActionResult Remove(int? id)
        {

            if (TempData["cart"] == null)
            {
                TempData.Remove("total");
                TempData.Remove("cart");
                TempData.Remove("item_count");
                return RedirectToAction("EmptyCart");
            }
            else
            {
                var xc = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);

                List<CartItem> li2 = xc as List<CartItem>;
                CartItem c = li2.Where(x => x.CartId == id).SingleOrDefault();
                li2.Remove(c);
                double? s = 0;
                foreach (var item in li2)
                {
                    s += item.CartTotal;
                }

                String srt = JsonConvert.SerializeObject(li2);
                TempData["cart"] = srt;
                String itemcu = JsonConvert.SerializeObject(li2.Count());
                TempData["item_count"] = itemcu;
                String tt = JsonConvert.SerializeObject(s);
                TempData["total"] = tt;

            }


            // String itemcu = JsonConvert.SerializeObject(li.Count());
            // String tt = JsonConvert.SerializeObject(h);
            // TempData["total"] = tt;
            //TempData["item_count"] = itemcu;
            // TempData.Keep();
            return RedirectToAction("Cart");

        }


        public IActionResult OrderSuccess()
        {
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            TempData.Keep();
            return View();
        }

        public IActionResult BillForm()
        {
            TempData.Keep();
            var nav = 1;
            ViewBag.nav = nav;
            ViewBag.footer = nav;
            double tto = (double)JsonConvert.DeserializeObject((string)TempData["total"]);
            double tt = tto;
            ViewBag.Total = string.Format("{0:n}", tt); ;
            TempData.Keep();

            return View();
        }

        [HttpPost]
        public IActionResult BillForm(string Name, string Email, string Phone, string Address, IFormFile Receipt)
        {
            TempData.Keep();
            double tto = (double)JsonConvert.DeserializeObject((string)TempData["total"]);
            double tt = tto;
            ViewBag.Total = string.Format("{0:n}", tt); ;

            if (ModelState.IsValid)
            {

                var xc = JsonConvert.DeserializeObject<List<CartItem>>((String)TempData["cart"]);
                List<CartItem> li2 = xc as List<CartItem>;

                TbCustomer cs = new TbCustomer();
                byte[] buffer = new byte[Receipt.Length];
                var resultInBytes = ConvertToBytes(Receipt);
                Array.Copy(resultInBytes, buffer, resultInBytes.Length);

                cs.CusName = Name;
                cs.CusEmail = Email;
                cs.CusPhone = Phone;
                cs.CusAddress = Address;
                cs.CusReceipt = buffer;

                _context.TbCustomers.Add(cs);
                _context.SaveChanges();



                //order book & update stock, saled
                foreach (var item in li2)
                {
                    TbBill bl = new TbBill();
                    bl.CusId = cs.CusId;
                    bl.PdId = item.CartId;
                    bl.BillDate = System.DateTime.Now;
                    bl.PdName = item.CartName;
                    bl.BillQty = item.CartQty;
                    bl.BillTotal = item.CartTotal;

                    _context.TbBills.Add(bl);
                    _context.SaveChanges();

                    int id = item.CartId;
                    TbProduct p = _context.TbProducts.Where(x => x.PdId == id).SingleOrDefault();
                    p.PdDelete += bl.BillQty;
                    p.PdStock -= bl.BillQty;

                    _context.TbProducts.Update(p);
                    _context.SaveChanges();
                }
                TempData.Remove("total");
                TempData.Remove("cart");
                TempData.Remove("item_count");
                return RedirectToAction("OrderSuccess");
            }

            TempData.Keep();
            return View();

        }

        ///Convert Image to Bytes
        private byte[] ConvertToBytes(IFormFile image)
        {
            using (var memoryStream = new MemoryStream())
            {
                image.OpenReadStream().CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public IActionResult Searchbox(string querry)
        {
            //if (ModelState.IsValid)
            //{
            {
                TempData.Keep();
                var nav = 1;
                ViewBag.nav = nav;
                ViewBag.footer = nav;
                if (string.IsNullOrEmpty(querry))
                {
                    TempData.Keep();
                    return View("ProductCategory", _context.TbProducts.ToList());

                }
                else
                {
                    TempData.Keep();
                    return View("ProductCategory", _context.TbProducts.Where(p => p.PdName.Contains(querry)).ToList());
                }
            }
            //}

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}