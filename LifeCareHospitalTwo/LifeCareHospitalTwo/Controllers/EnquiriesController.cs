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
    [ApiController]
    [Route("enquiry/ask")]
    public class EnquiriesController : Controller
    {
        private readonly LifeCareHospitalContext _context;

        public EnquiriesController(LifeCareHospitalContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Enquire(Enquiry enquiry)
        {
            var register = new Enquiry();
            register.FirstName = enquiry.FirstName;
            register.LastName = enquiry.LastName;
            register.Email = enquiry.Email;
            register.MobileNo = enquiry.MobileNo;
            register.Message = enquiry.Message;
     
            _context.Enquiries.Add(register);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enquiry>>> GetEnquiries()
        {
            Response.Headers.Add(new KeyValuePair<string,
                Microsoft.Extensions.Primitives.StringValues>("Access-Control-Allow-Origin", "*"));
            Response.Headers.Add(new KeyValuePair<string,
                Microsoft.Extensions.Primitives.StringValues>("Access-Control-Allow-Headers",
                "Origin, X-Requested-With, Content-Type, Accept, Authorization"));
            //return Json(_context.BookAppointments.ToListAsync());
            return await _context.Enquiries.ToListAsync();

        }

        // GET: Enquiries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enquiries.ToListAsync());
        }

        // GET: Enquiries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquiry = await _context.Enquiries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enquiry == null)
            {
                return NotFound();
            }

            return View(enquiry);
        }

        // GET: Enquiries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enquiries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,MobileNo,Email,Message")] Enquiry enquiry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enquiry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enquiry);
        }

        // GET: Enquiries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquiry = await _context.Enquiries.FindAsync(id);
            if (enquiry == null)
            {
                return NotFound();
            }
            return View(enquiry);
        }

        // POST: Enquiries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,MobileNo,Email,Message")] Enquiry enquiry)
        {
            if (id != enquiry.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enquiry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnquiryExists(enquiry.Id))
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
            return View(enquiry);
        }

        // GET: Enquiries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enquiry = await _context.Enquiries
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enquiry == null)
            {
                return NotFound();
            }

            return View(enquiry);
        }

        // POST: Enquiries/Delete/5
        //[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enquiry = await _context.Enquiries.FindAsync(id);
            _context.Enquiries.Remove(enquiry);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnquiryExists(int id)
        {
            return _context.Enquiries.Any(e => e.Id == id);
        }
    }
}
