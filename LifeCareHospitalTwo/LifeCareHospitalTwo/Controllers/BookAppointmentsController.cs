using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;

namespace LifeCareHospitalTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookAppointmentsController : Controller
    {
        private readonly LifeCareHospitalContext _context;

        public BookAppointmentsController(LifeCareHospitalContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookAppointment>>> GetUsers()
        {
            Response.Headers.Add(new KeyValuePair<string,
                Microsoft.Extensions.Primitives.StringValues>("Access-Control-Allow-Origin", "*"));
            Response.Headers.Add(new KeyValuePair<string,
                Microsoft.Extensions.Primitives.StringValues>("Access-Control-Allow-Headers",
                "Origin, X-Requested-With, Content-Type, Accept, Authorization"));
            //return Json(_context.BookAppointments.ToListAsync());
            return await _context.BookAppointments.ToListAsync();

        }

        
        [HttpPost]
        public async Task<ActionResult<BookAppointment>> PostUser(BookAppointment bookAppointment)
        {

            _context.BookAppointments.Add(bookAppointment);
            await _context.SaveChangesAsync();
            Response.Headers.Add(new KeyValuePair<string,
                Microsoft.Extensions.Primitives.StringValues>("Access-Control-Allow-Origin", "*"));
            Response.Headers.Add(new KeyValuePair<string,
                Microsoft.Extensions.Primitives.StringValues>("Access-Control-Allow-Headers",
                "Origin, X-Requested-With, Content-Type, Accept, Authorization"));
            //return Json(_context.BookAppointments.ToListAsync());
            return CreatedAtAction("GetUsers", new { id = bookAppointment.Id }, bookAppointment);
        }

        // GET: BookAppointments
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookAppointments.ToListAsync());
        }

        // GET: BookAppointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAppointment = await _context.BookAppointments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookAppointment == null)
            {
                return NotFound();
            }

            return View(bookAppointment);
        }

        // GET: BookAppointments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BookAppointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Gender,Address,MobileNo,Email,DoctorName,Speciality,AppointmentDate,AppointmentTime")] BookAppointment bookAppointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookAppointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookAppointment);
        }

        // GET: BookAppointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAppointment = await _context.BookAppointments.FindAsync(id);
            if (bookAppointment == null)
            {
                return NotFound();
            }
            return View(bookAppointment);
        }

        // POST: BookAppointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Gender,Address,MobileNo,Email,DoctorName,Speciality,AppointmentDate,AppointmentTime")] BookAppointment bookAppointment)
        {
            if (id != bookAppointment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookAppointment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookAppointmentExists(bookAppointment.Id))
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
            return View(bookAppointment);
        }

        // GET: BookAppointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookAppointment = await _context.BookAppointments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookAppointment == null)
            {
                return NotFound();
            }

            return View(bookAppointment);
        }

        // POST: BookAppointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookAppointment = await _context.BookAppointments.FindAsync(id);
            _context.BookAppointments.Remove(bookAppointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookAppointmentExists(int id)
        {
            return _context.BookAppointments.Any(e => e.Id == id);
        }
    }
}
