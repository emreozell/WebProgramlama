using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class IndirimController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IndirimController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Indirim
        public async Task<IActionResult> Index()
        {
            return View(await _context.Indirim.ToListAsync());
        }

        // GET: Indirim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indirim = await _context.Indirim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indirim == null)
            {
                return NotFound();
            }

            return View(indirim);
        }

        // GET: Indirim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Indirim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,indirimOrani")] Indirim indirim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indirim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indirim);
        }

        // GET: Indirim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indirim = await _context.Indirim.FindAsync(id);
            if (indirim == null)
            {
                return NotFound();
            }
            return View(indirim);
        }

        // POST: Indirim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,indirimOrani")] Indirim indirim)
        {
            if (id != indirim.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indirim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndirimExists(indirim.Id))
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
            return View(indirim);
        }

        // GET: Indirim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indirim = await _context.Indirim
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indirim == null)
            {
                return NotFound();
            }

            return View(indirim);
        }

        // POST: Indirim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var indirim = await _context.Indirim.FindAsync(id);
            _context.Indirim.Remove(indirim);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndirimExists(int id)
        {
            return _context.Indirim.Any(e => e.Id == id);
        }
    }
}
