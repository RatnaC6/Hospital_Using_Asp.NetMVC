﻿using System;
using System.Collections.Generic;

#nullable disable

namespace LifeCareHospital.Models
{
    public partial class Enquiry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}