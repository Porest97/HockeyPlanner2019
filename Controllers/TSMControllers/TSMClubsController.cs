using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyPlanner2019.Data;
using HockeyPlanner2019.Models.DataModels.TSMModels.DataModels;

namespace HockeyPlanner2019.Controllers.TSMControllers
{
    public class TSMClubsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TSMClubsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TSMClubs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.TSMClub
                .Include(t => t.Arena)
                .Include(t => t.City)
                .Include(t => t.Country)
                .Include(t => t.Covenant)
                .Include(t => t.District);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: TSMClubs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMClub = await _context.TSMClub
                .Include(t => t.Arena)
                .Include(t => t.City)
                .Include(t => t.Country)
                .Include(t => t.Covenant)
                .Include(t => t.District)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMClub == null)
            {
                return NotFound();
            }

            return View(tSMClub);
        }

        // GET: TSMClubs/Create
        public IActionResult Create()
        {
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName");
            ViewData["CityId"] = new SelectList(_context.Set<City>(), "Id", "CityName");
            ViewData["CountryId"] = new SelectList(_context.Set<Country>(), "Id", "CountryName");
            ViewData["CovenantId"] = new SelectList(_context.Set<Covenant>(), "Id", "CovenantName");
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName");
            return View();
        }

        // POST: TSMClubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TSMClubNO,TSMClubName,ShortName,StreetAddress,ZipCode,CityId,CountryId,PhoneNumber1,PhoneNumber2,Email,DistrictId,CovenantId,ArenaId")] TSMClub tSMClub)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tSMClub);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", tSMClub.ArenaId);
            ViewData["CityId"] = new SelectList(_context.Set<City>(), "Id", "CityName", tSMClub.CityId);
            ViewData["CountryId"] = new SelectList(_context.Set<Country>(), "Id", "CountryName", tSMClub.CountryId);
            ViewData["CovenantId"] = new SelectList(_context.Set<Covenant>(), "Id", "CovenantName", tSMClub.CovenantId);
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName", tSMClub.DistrictId);
            return View(tSMClub);
        }

        // GET: TSMClubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMClub = await _context.TSMClub.FindAsync(id);
            if (tSMClub == null)
            {
                return NotFound();
            }
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", tSMClub.ArenaId);
            ViewData["CityId"] = new SelectList(_context.Set<City>(), "Id", "CityName", tSMClub.CityId);
            ViewData["CountryId"] = new SelectList(_context.Set<Country>(), "Id", "CountryName", tSMClub.CountryId);
            ViewData["CovenantId"] = new SelectList(_context.Set<Covenant>(), "Id", "CovenantName", tSMClub.CovenantId);
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName", tSMClub.DistrictId);
            return View(tSMClub);
        }

        // POST: TSMClubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TSMClubNO,TSMClubName,ShortName,StreetAddress,ZipCode,CityId,CountryId,PhoneNumber1,PhoneNumber2,Email,DistrictId,CovenantId,ArenaId")] TSMClub tSMClub)
        {
            if (id != tSMClub.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tSMClub);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TSMClubExists(tSMClub.Id))
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
            ViewData["ArenaId"] = new SelectList(_context.Arena, "Id", "ArenaName", tSMClub.ArenaId);
            ViewData["CityId"] = new SelectList(_context.Set<City>(), "Id", "CityName", tSMClub.CityId);
            ViewData["CountryId"] = new SelectList(_context.Set<Country>(), "Id", "CountryName", tSMClub.CountryId);
            ViewData["CovenantId"] = new SelectList(_context.Set<Covenant>(), "Id", "CovenantName", tSMClub.CovenantId);
            ViewData["DistrictId"] = new SelectList(_context.Set<District>(), "Id", "DistrictName", tSMClub.DistrictId);
            return View(tSMClub);
        }

        // GET: TSMClubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tSMClub = await _context.TSMClub
                .Include(t => t.Arena)
                .Include(t => t.City)
                .Include(t => t.Country)
                .Include(t => t.Covenant)
                .Include(t => t.District)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tSMClub == null)
            {
                return NotFound();
            }

            return View(tSMClub);
        }

        // POST: TSMClubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tSMClub = await _context.TSMClub.FindAsync(id);
            _context.TSMClub.Remove(tSMClub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TSMClubExists(int id)
        {
            return _context.TSMClub.Any(e => e.Id == id);
        }
    }
}
