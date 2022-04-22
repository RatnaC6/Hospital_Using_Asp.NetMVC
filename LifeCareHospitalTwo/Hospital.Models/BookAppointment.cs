using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.Models
{
    public partial class BookAppointment
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
    }
}
