﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_MVC_Test.Data;
using final_MVC_Test.Models;
using Microsoft.AspNetCore.Authorization;

namespace final_MVC_Test.Areas.Admin.Controllers
{
    [Area("Admin")]
	[Authorize(Roles =SD.SuperAdminEndUser+","+SD.AdminEndUser)]
    public class SpecialTagsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpecialTagsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/SpecialTags
        public async Task<IActionResult> Index()
        {
            return View(await _context.SpecialTags.ToListAsync());
        }

        // GET: Admin/SpecialTags/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTag = await _context.SpecialTags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialTag == null)
            {
                return NotFound();
            }

            return View(specialTag);
        }

        // GET: Admin/SpecialTags/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SpecialTags/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialTag);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialTag);
        }

        // GET: Admin/SpecialTags/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTag = await _context.SpecialTags.FindAsync(id);
            if (specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }

        // POST: Admin/SpecialTags/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] SpecialTag specialTag)
        {
            if (id != specialTag.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialTag);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialTagExists(specialTag.Id))
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
            return View(specialTag);
        }

        // GET: Admin/SpecialTags/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialTag = await _context.SpecialTags
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialTag == null)
            {
                return NotFound();
            }

            return View(specialTag);
        }

        // POST: Admin/SpecialTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialTag = await _context.SpecialTags.FindAsync(id);
            _context.SpecialTags.Remove(specialTag);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialTagExists(int id)
        {
            return _context.SpecialTags.Any(e => e.Id == id);
        }
    }
}
