using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATUnivTest4
{
    [TestClass]
    public class Lecture07and08
    {
        IWebDriver driver = new ChromeDriver(@"c:\users\Public\Downloads");

        [TestInitialize]
        public void SetUp()

        {          
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();            
        }

        [TestMethod]
        public void GetPageTitle()
        {
            driver.Navigate().GoToUrl(@"https://www.takemefishing.org/");
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
