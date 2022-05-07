using Microsoft.VisualStudio.TestTools.UnitTesting;
using EAD_CA_PROJECT_INVEST.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;

namespace EAD_CA_PROJECT_INVEST.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        
        [TestMethod()]
        public void IndexTest()
        {
            var controller = new HomeController(new NullLogger<HomeController>());
            var result = controller.Index();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod()]
        public void PrivacyTest()
        {
            var controller = new HomeController(new NullLogger<HomeController>());
            var result = controller.Privacy();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        
        
    }
}