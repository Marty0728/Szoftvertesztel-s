using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private iWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
             driver = new ChromeDriver();
        }
        [TestMethod]
        public void Browser() 
        {
            driver.Navigate().GoToUrl("http://127.0.0.1:5000");
            Assert.IsTrue(driver.Title.Contains("127.0.0.1:5000"));
            //var driver = new ChromeDriver();
            
        }
        [TestCleanup]
        public void Stop()
        {
            driver.Quit();
        }
    }
}
