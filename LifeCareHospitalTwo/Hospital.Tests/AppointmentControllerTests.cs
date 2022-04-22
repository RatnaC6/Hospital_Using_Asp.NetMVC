using Hospital.Models;
using LifeCareHospitalTwo.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.Tests
{
    [TestClass]
    public class AppointmentControllerTests
    {
        [TestMethod]
        public void TestPostAppointment()
        {
            //Arrange
            var context = new LifeCareHospitalContext();
            var controller = new AppointmentController();
            var bkapt = new BookAppointment()
            {
                FirstName = "John",
                LastName = "Abraham",
                Gender = "Male",
                Address = "Mumbai",
                MobileNo = "1234567890",
                Email = "John@xyz.com",
                DoctorName = "Dr. Rani Shetty",
                Speciality = "Cancer Care",
                AppointmentDate = new DateTime(2022, 04, 28),
                AppointmentTime = new TimeSpan(8, 45, 10)
            };

            //Act
            var result = controller.Register(bkapt);
            var appointment = context.BookAppointments.Where(a => a.FirstName.Equals("John")).FirstOrDefault();

            //Assert
            Assert.AreEqual(bkapt.FirstName, appointment.FirstName,
                "The entry saved is not as per what was returned");
        }
    }
}
