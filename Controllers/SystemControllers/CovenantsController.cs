using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyPlanner2019.Data;
using HockeyPlanner2019.Models.DataModels.TSMModels.DataModels;

namespace HockeyPlanner2019.Controllers.SystemControllers
{
    public class CovenantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CovenantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Covenants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Covenant.ToListAsync());
        }

        // GET: Covenants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covenant = await _context.Covenant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (covenant == null)
            {
                return NotFound();
            }

            return View(covenant);
        }

        // GET: Covenants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Covenants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CovenantName")] Covenant covenant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(covenant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(covenant);
        }

        // GET: Covenants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covenant = await _context.Covenant.FindAsync(id);
            if (covenant == null)
            {
                return NotFound();
            }
            return View(covenant);
        }

        // POST: Covenants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CovenantName")] Covenant covenant)
        {
            if (id != covenant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(covenant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CovenantExists(covenant.Id))
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
            return View(covenant);
        }

        // GET: Covenants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covenant = await _context.Covenant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (covenant == null)
            {
                return NotFound();
            }

            return View(covenant);
        }

        // POST: Covenants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var covenant = await _context.Covenant.FindAsync(id);
            _context.Covenant.Remove(covenant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CovenantExists(int id)
        {
            return _context.Covenant.Any(e => e.Id == id);
        }
    }
}
