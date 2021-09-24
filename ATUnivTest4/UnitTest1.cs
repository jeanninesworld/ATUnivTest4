using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATUnivTest4
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver(@"c:\users\Public\Downloads");

        [TestInitialize]
        public void SetUp()

        {          
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();            
        }

        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl(@"http://www.agilethought.com");
            var title = driver.Title;
            Console.WriteLine(title);                
        }

        [TestCleanup]
        public void TearDown()
        {
           driver.Quit();            
        }
    }
}
