using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NKLBAITHI2324.Data;
using NKLBAITHI2324.Models;

namespace NKLBAITHI2324.Controllers
{
    public class NKL391PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NKL391PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NKL391Person
        public async Task<IActionResult> Index()
        {
            return View(await _context.NKL391Persons.ToListAsync());
        }

        // GET: NKL391Person/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nKL391Person = await _context.NKL391Persons
                .FirstOrDefaultAsync(m => m.Ngaysinh == id);
            if (nKL391Person == null)
            {
                return NotFound();
            }

            return View(nKL391Person);
        }

        // GET: NKL391Person/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NKL391Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Ngaysinh,HoTen,DiaChi")] NKL391Person nKL391Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nKL391Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nKL391Person);
        }

        // GET: NKL391Person/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nKL391Person = await _context.NKL391Persons.FindAsync(id);
            if (nKL391Person == null)
            {
                return NotFound();
            }
            return View(nKL391Person);
        }

        // POST: NKL391Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Ngaysinh,HoTen,DiaChi")] NKL391Person nKL391Person)
        {
            if (id != nKL391Person.Ngaysinh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nKL391Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NKL391PersonExists(nKL391Person.Ngaysinh))
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
            return View(nKL391Person);
        }

        // GET: NKL391Person/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nKL391Person = await _context.NKL391Persons
                .FirstOrDefaultAsync(m => m.Ngaysinh == id);
            if (nKL391Person == null)
            {
                return NotFound();
            }

            return View(nKL391Person);
        }

        // POST: NKL391Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nKL391Person = await _context.NKL391Persons.FindAsync(id);
            if (nKL391Person != null)
            {
                _context.NKL391Persons.Remove(nKL391Person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NKL391PersonExists(int id)
        {
            return _context.NKL391Persons.Any(e => e.Ngaysinh == id);
        }
    }
}
