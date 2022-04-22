using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;

namespace LifeCareHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookAppointmentController : Controller
    {
        private readonly LifeCareHospitalContext _context;

        public BookAppointmentController(LifeCareHospitalContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookAppointmentTwo>>> GetUsers()
        {
            return await _context.BookAppointmentTwos.ToListAsync();
        }

        [HttpPost("{add}")]
        public async Task<ActionResult<BookAppointmentTwo>> PostUser(BookAppointmentTwo bookAppointmentTwo)
        {

            _context.BookAppointmentTwos.Add(bookAppointmentTwo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers", new { id = bookAppointmentTwo.Id }, bookAppointmentTwo);
        }


       
        //// GET: BookAppointment
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.BookAppointmentTwos.ToListAsync());
        //}

        // GET: BookAppointment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAppointmentTwo = await _context.BookAppointmentTwos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookAppointmentTwo == null)
            {
                return NotFound();
            }

            return View(bookAppointmentTwo);
        }

        // GET: BookAppointment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookAppointment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Gender,Address,MobileNo,Email,DoctorName,Speciality,AppointmentDate,AppointmentTime")] BookAppointmentTwo bookAppointmentTwo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookAppointmentTwo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookAppointmentTwo);
        }

        // GET: BookAppointment/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAppointmentTwo = await _context.BookAppointmentTwos.FindAsync(id);
            if (bookAppointmentTwo == null)
            {
                return NotFound();
            }
            return View(bookAppointmentTwo);
        }

        // POST: BookAppointment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Gender,Address,MobileNo,Email,DoctorName,Speciality,AppointmentDate,AppointmentTime")] BookAppointmentTwo bookAppointmentTwo)
        {
            if (id != bookAppointmentTwo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookAppointmentTwo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookAppointmentTwoExists(bookAppointmentTwo.Id))
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
            return View(bookAppointmentTwo);
        }

        // GET: BookAppointment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAppointmentTwo = await _context.BookAppointmentTwos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookAppointmentTwo == null)
            {
                return NotFound();
            }

            return View(bookAppointmentTwo);
        }

        // POST: BookAppointment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookAppointmentTwo = await _context.BookAppointmentTwos.FindAsync(id);
            _context.BookAppointmentTwos.Remove(bookAppointmentTwo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookAppointmentTwoExists(int id)
        {
            return _context.BookAppointmentTwos.Any(e => e.Id == id);
        }
    }
}
