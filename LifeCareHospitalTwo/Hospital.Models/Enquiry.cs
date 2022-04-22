using System;
using System.Collections.Generic;

#nullable disable

namespace Hospital.Models
{
    public partial class Enquiry
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
