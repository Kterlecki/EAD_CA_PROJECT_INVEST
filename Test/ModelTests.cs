using EAD_CA_PROJECT_INVEST.Model;
using NUnit.Framework.Internal;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD_CA_PROJECT_INVESTTests.Test
{
    [TestClass()]
    public class ModelTests
    {
        [TestMethod()]
        public void CreateUser()
        {
            User u = new User() { UserID = 10, Name = "abc", Email = "abc@gmail.com", UserType=UserType.admin };

            Assert.IsInstanceOfType(u, typeof(User));
            Assert.AreEqual(u.UserID, 10);
            Assert.AreEqual(u.Name, "abc");
            Assert.AreEqual(u.Email, "abc@gmail.com");
            Assert.AreEqual(u.UserType, UserType.admin);
        }
        [TestMethod()]
        public void CreateStock()
        {
            Stock s = new Stock() {
                StockID = 10,
                StockName = "Google",
                StockTicker = "GOO",
                StockPrice = 10,
                SellPrice = 10,
                TotalShares = 10,
                ExchangeName = "Test",
            };

            Assert.IsInstanceOfType(s, typeof(Stock));
            Assert.AreEqual(s.StockID, 10);
            Assert.AreEqual(s.StockName, "Google");
            Assert.AreEqual(s.StockTicker, "GOO");
            Assert.AreEqual(s.StockPrice, 10);
            Assert.AreEqual(s.SellPrice, 10);
            Assert.AreEqual(s.TotalShares, 10);
            Assert.AreEqual(s.ExchangeName, "Test");
        }
        [TestMethod()]
        public void CreateOrder()
        {
            Order o = new Order()
            {
                OrderID = 10,
                PurchasePrice = 10,
            };

            Assert.IsInstanceOfType(o, typeof(Order));
            Assert.AreEqual(o.OrderID, 10);
            Assert.AreEqual(o.PurchasePrice, 10);
        }
    }
}
