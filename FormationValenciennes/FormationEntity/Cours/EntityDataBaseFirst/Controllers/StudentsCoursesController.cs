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
    public class StudentsCoursesController : Controller
    {
        private readonly masterContext _context;

        public StudentsCoursesController(masterContext context)
        {
            _context = context;
        }

        // GET: StudentsCourses
        public async Task<IActionResult> Index()
        {
            var masterContext = _context.StudentsCourses.Include(s => s.Course).Include(s => s.Student);
            return View(await masterContext.ToListAsync());
        }

        // GET: StudentsCourses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsCourse = await _context.StudentsCourses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentsCourse == null)
            {
                return NotFound();
            }

            return View(studentsCourse);
        }

        // GET: StudentsCourses/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname");
            return View();
        }

        // POST: StudentsCourses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,CourseId")] StudentsCourse studentsCourse)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentsCourse);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name", studentsCourse.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname", studentsCourse.StudentId);
            return View(studentsCourse);
        }

        // GET: StudentsCourses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsCourse = await _context.StudentsCourses.FindAsync(id);
            if (studentsCourse == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name", studentsCourse.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname", studentsCourse.StudentId);
            return View(studentsCourse);
        }

        // POST: StudentsCourses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,CourseId")] StudentsCourse studentsCourse)
        {
            if (id != studentsCourse.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentsCourse);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentsCourseExists(studentsCourse.StudentId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "Id", "Name", studentsCourse.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Firstname", studentsCourse.StudentId);
            return View(studentsCourse);
        }

        // GET: StudentsCourses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentsCourse = await _context.StudentsCourses
                .Include(s => s.Course)
                .Include(s => s.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (studentsCourse == null)
            {
                return NotFound();
            }

            return View(studentsCourse);
        }

        // POST: StudentsCourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentsCourse = await _context.StudentsCourses.FindAsync(id);
            _context.StudentsCourses.Remove(studentsCourse);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsCourseExists(int id)
        {
            return _context.StudentsCourses.Any(e => e.StudentId == id);
        }
    }
}
