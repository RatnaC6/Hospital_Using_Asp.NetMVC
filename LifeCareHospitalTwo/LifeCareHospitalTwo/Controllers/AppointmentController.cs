using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace LifeCareHospitalTwo.Controllers
{
    [ApiController]
    [Route("patient/register")]
    public class AppointmentController : Controller
    {
        LifeCareHospitalContext context = new LifeCareHospitalContext(); 

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(BookAppointment bookAppointment)
        {
            var register = new BookAppointment();
            register.FirstName = bookAppointment.FirstName;
            register.LastName = bookAppointment.LastName;
            register.Gender = bookAppointment.Gender;
            register.Email = bookAppointment.Email;
            register.MobileNo = bookAppointment.MobileNo;
            register.Address = bookAppointment.Address;
            register.DoctorName = bookAppointment.DoctorName;
            register.Speciality = bookAppointment.Speciality;
            register.AppointmentDate = bookAppointment.AppointmentDate;
            register.AppointmentTime = bookAppointment.AppointmentTime;



            context.BookAppointments.Add(register);
            context.SaveChanges();
            return Ok();
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
            return await context.BookAppointments.ToListAsync();
        }
    }
}
