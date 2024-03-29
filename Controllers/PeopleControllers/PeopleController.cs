﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HockeyPlanner2019.Data;
using HockeyPlanner2019.Models.DataModels;
using Microsoft.AspNetCore.Identity;

namespace HockeyPlanner2019.Controllers.PeopleControllers
{
    public class PeopleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: People
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Person
                .Include(p => p.Club)
                .Include(p => p.Company)
                .Include(p => p.PersonType)
                .Include(p=>p.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: People/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.Company)
                .Include(p => p.PersonType)
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // GET: People/Create
        public IActionResult Create()
        {
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName");
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "ComanyName");
            ViewData["PersonTypeId"] = new SelectList(_context.Set<PersonType>(), "Id", "PersonTypeName");
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Email");
            return View();
        }

        // POST: People/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,StreetAddress,ZipCode,City,Country,Ssn,PhoneNumber1,PhoneNumber2,Email,PersonTypeId,CompanyId,ClubId,SwishNumber,BankAccount,BankName,IdentityUserId")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId);
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "CompanyName", person.CompanyId);
            ViewData["PersonTypeId"] = new SelectList(_context.Set<PersonType>(), "Id", "PersonTypeName", person.PersonTypeId);
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Email", person.IdentityUserId);
            return View(person);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId);
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "CompanyName", person.CompanyId);
            ViewData["PersonTypeId"] = new SelectList(_context.Set<PersonType>(), "Id", "PersonTypeName", person.PersonTypeId);
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Email", person.IdentityUserId);
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,StreetAddress,ZipCode,City,Country,Ssn,PhoneNumber1,PhoneNumber2,Email,PersonTypeId,CompanyId,ClubId,SwishNumber,BankAccount,BankName,IdentityUserId")] Person person)
        {
            if (id != person.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.Id))
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
            ViewData["ClubId"] = new SelectList(_context.Set<Club>(), "Id", "ClubName", person.ClubId);
            ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "Id", "CompanyName", person.CompanyId);
            ViewData["PersonTypeId"] = new SelectList(_context.Set<PersonType>(), "Id", "PersonTypeName", person.PersonTypeId);
            ViewData["IdentityUserId"] = new SelectList(_context.Set<IdentityUser>(), "Id", "Email", person.IdentityUserId);
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.Person
                .Include(p => p.Club)
                .Include(p => p.Company)
                .Include(p => p.PersonType)
                .Include(p => p.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var person = await _context.Person.FindAsync(id);
            _context.Person.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonExists(int id)
        {
            return _context.Person.Any(e => e.Id == id);
        }
    }
}
