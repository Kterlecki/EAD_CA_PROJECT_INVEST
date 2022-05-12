using Microsoft.VisualStudio.TestTools.UnitTesting;
using EAD_CA_PROJECT_INVEST.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using EAD_CA_PROJECT_INVEST.Data;
using EAD_CA_PROJECT_INVEST.Model;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;
using System.Web.Http;

namespace EAD_CA_PROJECT_INVEST.Controllers.Tests
{
    [TestClass()]
    public class UsersControllerTests

    {
        [TestMethod]
        public void Test_Create_Pass()
        {
            var mockDb = GetDbContext();
            var mockController = new UsersController(mockDb);

            User u = new User() { UserID = 10, Name = "abc", Email = "abc@gmail.com", UserType = UserType.admin };
            var result = mockController.Create(u);


            Assert.IsNotNull(result);
            Assert.AreEqual(10, u.UserID);
            //Assert.IsInstanceOfType(result, typeof(User));

        }
        [TestMethod]
        public void Details_Pass()
        {
            var mockDb = GetDbContext();
            var mockController = new UsersController(mockDb);


            User u = new User() { UserID = 10, Name = "abc", Email = "abc@gmail.com", UserType = UserType.admin };
            var result = mockController.Details(10);


            Assert.IsNotNull(result);
            Assert.AreEqual(10, u.UserID);
            Assert.AreEqual("abc", u.Name);
            

        }
        [TestMethod]
        public void Delete_Fail_IDDoesntExist()
        {
            var mockDb = GetDbContext();
            var mockController = new UsersController(mockDb);

            User u = new User() { UserID = 10, Name = "abc", Email = "abc@gmail.com", UserType = UserType.admin };
            var result = mockController.Create(u);
            var delete = mockController.Delete(10);




            Assert.IsNotNull(delete);
            //Assert.IsTrue(result);
            //Assert.IsInstanceOfType(delete, typeof(IActionResult));



        }

        private INVESTContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<INVESTContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new INVESTContext(options);
            databaseContext.Database.EnsureCreated();
            if (databaseContext.Stock.Count() < 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    databaseContext.Stock.Add(
                        new Stock()
                        {
                            StockID = 10,
                            StockName = "Google",
                            StockTicker = "GOO",
                            StockPrice = 10,
                            SellPrice = 10,
                            TotalShares = 10,
                            ExchangeName = "Test",
                            //Order = null
                        });
                    databaseContext.SaveChanges();
                }

            }
            return databaseContext;
        }
    }
}