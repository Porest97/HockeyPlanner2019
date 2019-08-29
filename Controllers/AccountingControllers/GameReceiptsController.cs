using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyPlanner2019.Data;
using HockeyPlanner2019.Models.DataModels;

namespace HockeyPlanner2019.Controllers.AccountingControllers
{
    public class GameReceiptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GameReceipts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.GameReceipt.Include(g => g.Game).Include(g => g.HD1).Include(g => g.HD2).Include(g => g.LD1).Include(g => g.LD2).Include(g => g.ReceiptStatus);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: GameReceipts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameReceipt = await _context.GameReceipt
                .Include(g => g.Game)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .Include(g => g.ReceiptStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameReceipt == null)
            {
                return NotFound();
            }

            return View(gameReceipt);
        }

        // GET: GameReceipts/Create
        public IActionResult Create()
        {
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id");
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id");
            return View();
        }

        // POST: GameReceipts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameId,PersonId,PersonId1,PersonId2,PersonId3,HD1Fee,HD1TravelKost,HD1Alowens,HD1LateGameKost,HD1TotalFee,HD2Fee,HD2TravelKost,HD2Alowens,HD2LateGameKost,HD2TotalFee,LD1Fee,LD1TravelKost,LD1Alowens,LD1LateGameKost,LD1TotalFee,LD2Fee,LD2TravelKost,LD2Alowens,LD2LateGameKost,LD2TotalFee,GameTotalKost,AmountPaidHD1,AmountPaidHD2,AmountPaidLD1,AmountPaidLD2,TotalAmountPaid,TotalAmountToPay,ReceiptStatusId")] GameReceipt gameReceipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", gameReceipt.GameId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId3);
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id", gameReceipt.ReceiptStatusId);
            return View(gameReceipt);
        }

        // GET: GameReceipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameReceipt = await _context.GameReceipt.FindAsync(id);
            if (gameReceipt == null)
            {
                return NotFound();
            }
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", gameReceipt.GameId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId3);
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id", gameReceipt.ReceiptStatusId);
            return View(gameReceipt);
        }

        // POST: GameReceipts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameId,PersonId,PersonId1,PersonId2,PersonId3,HD1Fee,HD1TravelKost,HD1Alowens,HD1LateGameKost,HD1TotalFee,HD2Fee,HD2TravelKost,HD2Alowens,HD2LateGameKost,HD2TotalFee,LD1Fee,LD1TravelKost,LD1Alowens,LD1LateGameKost,LD1TotalFee,LD2Fee,LD2TravelKost,LD2Alowens,LD2LateGameKost,LD2TotalFee,GameTotalKost,AmountPaidHD1,AmountPaidHD2,AmountPaidLD1,AmountPaidLD2,TotalAmountPaid,TotalAmountToPay,ReceiptStatusId")] GameReceipt gameReceipt)
        {
            if (id != gameReceipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameReceiptExists(gameReceipt.Id))
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
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", gameReceipt.GameId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId);
            ViewData["PersonId1"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId1);
            ViewData["PersonId2"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId2);
            ViewData["PersonId3"] = new SelectList(_context.Person, "Id", "Id", gameReceipt.PersonId3);
            ViewData["ReceiptStatusId"] = new SelectList(_context.Set<ReceiptStatus>(), "Id", "Id", gameReceipt.ReceiptStatusId);
            return View(gameReceipt);
        }

        // GET: GameReceipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameReceipt = await _context.GameReceipt
                .Include(g => g.Game)
                .Include(g => g.HD1)
                .Include(g => g.HD2)
                .Include(g => g.LD1)
                .Include(g => g.LD2)
                .Include(g => g.ReceiptStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (gameReceipt == null)
            {
                return NotFound();
            }

            return View(gameReceipt);
        }

        // POST: GameReceipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameReceipt = await _context.GameReceipt.FindAsync(id);
            _context.GameReceipt.Remove(gameReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameReceiptExists(int id)
        {
            return _context.GameReceipt.Any(e => e.Id == id);
        }
    }
}
