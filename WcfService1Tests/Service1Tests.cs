using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetMyEmailTest()
        {
            //Arrange

            var service1 = new Service1();

            //Act

            string email = service1.GetMyEmail();

            //Assert

            Assert.AreEqual("Lasses Email", email);
        }

        [TestMethod()]
        public void GetMyNameTest()
        {
            var service2 = new Service1();

            string navn = service2.GetMyName();
            
            Assert.AreEqual("Lasse", navn);
        }
    }
}