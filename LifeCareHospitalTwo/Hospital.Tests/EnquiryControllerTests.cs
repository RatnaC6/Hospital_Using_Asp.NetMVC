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
    public class EnquiryControllerTests
    {
        [TestMethod]
        public void TestPostEnquiry()
        {
            //Arrange
            var context = new LifeCareHospitalContext();
            var controller = new EnquiriesController(context);
            var enq = new Enquiry()
            {
                FirstName = "John",
                LastName = "Abraham",
                Email = "John@xyz.com",
                MobileNo = "1234567890",
                Message = "Can I get a copy of bill?"
            };

            //Act
            var result = controller.Enquire(enq);
            var asked = context.Enquiries.Where(a => a.FirstName.Equals("John")).FirstOrDefault();

            //Assert
            Assert.AreEqual(enq.FirstName, asked.FirstName,
                "The entry saved is not as per what was returned");
        }
    }
}
