using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATUnivTest4
{
    [TestClass]
    public class Lecture13
    {
        IWebDriver driver = new ChromeDriver(@"c:\users\Public\Downloads");

        [TestInitialize]
        public void Setup()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();

        }

        [TestMethod]
        [TestCategory("Search")]
        public void searchFile()
        {
            driver.Navigate().GoToUrl(@"http://www.google.com");
            var search = driver.FindElement(By.Name("q"));
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\MySearch.txt");

            search.SendKeys(text);
            search.SendKeys(Keys.Return);
        }
    }
}
