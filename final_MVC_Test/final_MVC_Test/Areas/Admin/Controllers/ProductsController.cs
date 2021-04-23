using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_MVC_Test.Data;
using final_MVC_Test.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;

using System.IO;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace final_MVC_Test.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.SuperAdminEndUser + "," + SD.AdminEndUser)]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
		private readonly IHostingEnvironment hostingEnvironment;

		public ProductsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment )
        {
            _context = context;
			this.hostingEnvironment = hostingEnvironment;
		}

        // GET: Admin/Products
        public async Task<IActionResult> Index(String name = "")
        {
            if (name == null)
                name = "";
            var applicationDbContext = _context.Products.Where(p=>p.Name.Contains(name)).Include(p => p.ProductType).Include(p => p.SpecialTag);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductType)
                .Include(p => p.SpecialTag)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name");
            ViewData["SpecialTagsId"] = new SelectList(_context.SpecialTags, "Id", "Name");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Available,Image,ShadeColor,ProductTypeId,SpecialTagsId")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();

                string webRootPath = hostingEnvironment.WebRootPath;
                //Trace.WriteLine("marinaaaaaaa  =>"+ HttpContext.Request.Form.Files.ToString());
                var files = HttpContext.Request.Form.Files;

                var productsFromDb = _context.Products.Find(product.Id);

                if (files.Count != 0)
                {
                    var uploads = Path.Combine(webRootPath, @"images\Products");
                    var extention = Path.GetExtension(files[0].FileName);
                    using (var filestram = new FileStream(Path.Combine(uploads, product.Id + extention), FileMode.Create))

                    {
                        files[0].CopyTo(filestram);
                    }

                    productsFromDb.Image = @"\" + @"images\Products" + @"\" + product.Id + extention;

                }
                else
                {

                    var uploads = Path.Combine(webRootPath, @"images\Products" + @"\" + "defaultImages.jfif");
                    System.IO.File.Copy(uploads, webRootPath + @"\" + @"images\Products" + @"\" + product.Id + ".jfif");
                    productsFromDb.Image = @"\" + @"images\Products" + @"\" + product.Id + ".jfif";


                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
           

            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", product.ProductTypeId);
            ViewData["SpecialTagsId"] = new SelectList(_context.SpecialTags, "Id", "Name", product.SpecialTagsId);
            //return RedirectToAction(nameof(Index));
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", product.ProductTypeId);
            ViewData["SpecialTagsId"] = new SelectList(_context.SpecialTags, "Id", "Name", product.SpecialTagsId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price,Available,Image,ShadeColor,ProductTypeId,SpecialTagsId")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string webRootPath = hostingEnvironment.WebRootPath;
                    var files = HttpContext.Request.Form.Files;

                    var productFromDb = _context.Products.Where(m => m.Id == product.Id).AsNoTracking().FirstOrDefault();


                    if (files.Count > 0 && files[0] != null)
                    {
                        var uplaods = Path.Combine(webRootPath, @"images\Products");
                        var extension_new = Path.GetExtension(files[0].FileName);
                        var extension_old = Path.GetExtension(productFromDb.Image);

                        if (System.IO.File.Exists(Path.Combine(uplaods, product.Id + extension_old)))
                        {
                            System.IO.File.Delete(Path.Combine(uplaods, product.Id + extension_old));
                        }

                        using (var fileStream = new FileStream(Path.Combine(uplaods, product.Id + extension_new), FileMode.Create))

                        {
                            files[0].CopyTo(fileStream);
                        }

                        product.Image =  @"\images\Products\"  +product.Id + extension_new;


                    }

                    if (product.Image != null)
                    {
                        productFromDb.Image = product.Image;
                    }
                    else
                    {
                        product.Image = productFromDb.Image;
                    }
                        ////////////////////////////////////////////

                    //_context.Update(productFromDb);
                    _context.Entry<Product>(product).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProductTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", product.ProductTypeId);
            ViewData["SpecialTagsId"] = new SelectList(_context.SpecialTags, "Id", "Name", product.SpecialTagsId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.ProductType)
                .Include(p => p.SpecialTag)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
