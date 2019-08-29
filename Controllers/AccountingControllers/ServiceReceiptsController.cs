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
    public class ServiceReceiptsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceReceiptsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ServiceReceipts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ServiceReceipt
                .Include(s => s.Company)
                .Include(s => s.ReceiptStatus)
                .Include(s => s.Service)
                .Include(s => s.ServiceProvider);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: ServiceReceipts HttpPost !
        [HttpPost]
        public IActionResult Index(ServiceReceipt serviceReceipt)
        {
            var applicationDbContext = _context.ServiceReceipt
               .Include(s => s.Company)
                .Include(s => s.ReceiptStatus)
                .Include(s => s.Service)
                .Include(s => s.ServiceProvider);

            serviceReceipt.TotalPayment = serviceReceipt.Quantity * serviceReceipt.Price;
            serviceReceipt.TotalAmountToPay = serviceReceipt.TotalPayment - serviceReceipt.TotalAmountPaid;
            return View(serviceReceipt);
        }
            // GET: ServiceReceipts/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceReceipt = await _context.ServiceReceipt
                .Include(s => s.Company)
                .Include(s => s.ReceiptStatus)
                .Include(s => s.Service)
                .Include(s => s.ServiceProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceReceipt == null)
            {
                return NotFound();
            }

            return View(serviceReceipt);
        }

        // GET: ServiceReceipts/Create
        public IActionResult Create()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "ComanyName");
            ViewData["ReceiptStatusId"] = new SelectList(_context.ReceiptStatus, "Id", "ReceiptStatusName");
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "ServiceName");
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName");
            return View();
        }

        // POST: ServiceReceipts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PersonId,ServiceId,Quantity,Price,TotalPayment,CompanyId,TotalAmountPaid,TotalAmountToPay,ReceiptStatusId")] ServiceReceipt serviceReceipt)
        {
            if (ModelState.IsValid)
            {
                var applicationDbContext = _context.ServiceReceipt
                .Include(s => s.Company)
                .Include(s => s.ReceiptStatus)
                .Include(s => s.Service)
                .Include(s => s.ServiceProvider);

                serviceReceipt.TotalPayment = serviceReceipt.Quantity * serviceReceipt.Price;
                serviceReceipt.TotalAmountToPay = serviceReceipt.TotalPayment - serviceReceipt.TotalAmountPaid;


                _context.Add(serviceReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "ComanyName", serviceReceipt.CompanyId);
            ViewData["ReceiptStatusId"] = new SelectList(_context.ReceiptStatus, "Id", "ReceiptStatusName", serviceReceipt.ReceiptStatusId);
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "ServiceName", serviceReceipt.ServiceId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", serviceReceipt.PersonId);
            return View(serviceReceipt);
        }

        // GET: ServiceReceipts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceReceipt = await _context.ServiceReceipt.FindAsync(id);
            if (serviceReceipt == null)
            {
                return NotFound();
            }
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "ComanyName", serviceReceipt.CompanyId);
            ViewData["ReceiptStatusId"] = new SelectList(_context.ReceiptStatus, "Id", "ReceiptStatusName", serviceReceipt.ReceiptStatusId);
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "ServiceName", serviceReceipt.ServiceId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", serviceReceipt.PersonId);
            return View(serviceReceipt);
        }

        // POST: ServiceReceipts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PersonId,ServiceId,Quantity,Price,TotalPayment,CompanyId,TotalAmountPaid,TotalAmountToPay,ReceiptStatusId")] ServiceReceipt serviceReceipt)
        {
            if (id != serviceReceipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var applicationDbContext = _context.ServiceReceipt
                    .Include(s => s.Company)
                    .Include(s => s.ReceiptStatus)
                    .Include(s => s.Service)
                    .Include(s => s.ServiceProvider);

                    serviceReceipt.TotalPayment = serviceReceipt.Quantity * serviceReceipt.Price;
                    serviceReceipt.TotalAmountToPay = serviceReceipt.TotalPayment - serviceReceipt.TotalAmountPaid;

                    _context.Update(serviceReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceReceiptExists(serviceReceipt.Id))
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
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "ComanyName", serviceReceipt.CompanyId);
            ViewData["ReceiptStatusId"] = new SelectList(_context.ReceiptStatus, "Id", "ReceiptStatusName", serviceReceipt.ReceiptStatusId);
            ViewData["ServiceId"] = new SelectList(_context.Service, "Id", "ServiceName", serviceReceipt.ServiceId);
            ViewData["PersonId"] = new SelectList(_context.Person, "Id", "FullName", serviceReceipt.PersonId);
            return View(serviceReceipt);
        }

        // GET: ServiceReceipts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceReceipt = await _context.ServiceReceipt
                .Include(s => s.Company)
                .Include(s => s.ReceiptStatus)
                .Include(s => s.Service)
                .Include(s => s.ServiceProvider)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceReceipt == null)
            {
                return NotFound();
            }

            return View(serviceReceipt);
        }

        // POST: ServiceReceipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceReceipt = await _context.ServiceReceipt.FindAsync(id);
            _context.ServiceReceipt.Remove(serviceReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceReceiptExists(int id)
        {
            return _context.ServiceReceipt.Any(e => e.Id == id);
        }
    }
}
