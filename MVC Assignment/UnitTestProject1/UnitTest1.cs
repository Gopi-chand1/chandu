using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using MVCApplication.BookEvent.Home.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestProject1.test
{
    [TestClass]
    public class TestHomeController
    {
        [TestMethod]
        public void TestLogin()
        {
            HomeController obj = new HomeController(null);
            var result = obj.Login("admin", "admin@123") as ViewResult;
            Assert.AreEqual("AdminDashboard", result);
        }
    }
}
