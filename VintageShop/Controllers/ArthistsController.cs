using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VintageShop.Data;
using VintageShop.Models;

namespace VintageShop.Controllers
{
    public class ArthistsController : Controller
    {
        private readonly VintageShopContext _context;

        public ArthistsController(VintageShopContext context)
        {
            _context = context;
        }

        // GET: Arthists
        public async Task<IActionResult> Index()
        {
            return View(await _context.Arthists.ToListAsync());
        }

        // GET: Arthists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arthist = await _context.Arthists
                .FirstOrDefaultAsync(m => m.ID == id);
            if (arthist == null)
            {
                return NotFound();
            }

            return View(arthist);
        }

        // GET: Arthists/Details/5
        public async Task<IActionResult> AllAlbums(int? id, int? albumId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arthist = await _context.Arthists
               //

            if (arthist == null)
            {
                return NotFound();
            }

            return View(arthist);
        }

        // GET: Arthists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Arthists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Alias")] Arthist arthist)
        {
            if (ModelState.IsValid)
            {
                _context.Add(arthist);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arthist);
        }

        // GET: Arthists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arthist = await _context.Arthists.FindAsync(id);
            if (arthist == null)
            {
                return NotFound();
            }
            return View(arthist);
        }

        // POST: Arthists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Alias")] Arthist arthist)
        {
            if (id != arthist.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(arthist);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArthistExists(arthist.ID))
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
            return View(arthist);
        }

        // GET: Arthists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arthist = await _context.Arthists
                .FirstOrDefaultAsync(m => m.ID == id);
            if (arthist == null)
            {
                return NotFound();
            }

            return View(arthist);
        }

        // POST: Arthists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var arthist = await _context.Arthists.FindAsync(id);
            _context.Arthists.Remove(arthist);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArthistExists(int id)
        {
            return _context.Arthists.Any(e => e.ID == id);
        }
    }
}
