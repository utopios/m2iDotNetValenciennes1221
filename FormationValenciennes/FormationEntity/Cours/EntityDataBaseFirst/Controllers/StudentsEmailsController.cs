using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityDataBaseFirst.Models;

namespace EntityDataBaseFirst.Controllers
{
    public class StudentsEmailsController : Controller
    {
        private readonly masterContext _context;

        public StudentsEmailsController(masterContext context)
        {
            _context = context;
        }

        // GET: StudentsEmails
        public async Task<IActionResult> Index()
        {
            var masterContext = _context.StudentsEmails.Include(s => s.Email).Include(s => s.Student);
            return View(await masterContext.ToListAsync());
        }

        // GET: StudentsEmails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsEmail = await _context.StudentsEmails
                .Include(s => s.Email)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentsEmail == null)
            {
                return NotFound();
            }

            return View(studentsEmail);
        }

        // GET: StudentsEmails/Create
        public IActionResult Create()
        {
            ViewData["EmailId"] = new SelectList(_context.Emails, "Id", "Email1");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname");
            return View();
        }

        // POST: StudentsEmails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,EmailId")] StudentsEmail studentsEmail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentsEmail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmailId"] = new SelectList(_context.Emails, "Id", "Email1", studentsEmail.EmailId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname", studentsEmail.StudentId);
            return View(studentsEmail);
        }

        // GET: StudentsEmails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsEmail = await _context.StudentsEmails.FindAsync(id);
            if (studentsEmail == null)
            {
                return NotFound();
            }
            ViewData["EmailId"] = new SelectList(_context.Emails, "Id", "Email1", studentsEmail.EmailId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname", studentsEmail.StudentId);
            return View(studentsEmail);
        }

        // POST: StudentsEmails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,EmailId")] StudentsEmail studentsEmail)
        {
            if (id != studentsEmail.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentsEmail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsEmailExists(studentsEmail.StudentId))
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
            ViewData["EmailId"] = new SelectList(_context.Emails, "Id", "Email1", studentsEmail.EmailId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname", studentsEmail.StudentId);
            return View(studentsEmail);
        }

        // GET: StudentsEmails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsEmail = await _context.StudentsEmails
                .Include(s => s.Email)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentsEmail == null)
            {
                return NotFound();
            }

            return View(studentsEmail);
        }

        // POST: StudentsEmails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentsEmail = await _context.StudentsEmails.FindAsync(id);
            _context.StudentsEmails.Remove(studentsEmail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsEmailExists(int id)
        {
            return _context.StudentsEmails.Any(e => e.StudentId == id);
        }
    }
}
