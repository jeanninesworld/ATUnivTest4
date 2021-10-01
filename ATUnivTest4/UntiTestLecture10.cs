using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ATUnivTest4
{
    [TestClass]
    public class Lecture10
    {
        IWebDriver driver = new ChromeDriver(@"c:\users\Public\Downloads");

        [TestInitialize]
        public void SetUp()

        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void FindElementByDifferentMethods()
        {
            driver.Navigate().GoToUrl(@"https://www.takemefishing.org/");
            driver.FindElement(By.CssSelector("#nav-learn > span > span")).Click();
            driver.FindElement(By.XPath("/html/body/form/div[5]/div[1]/div[2]/div/div[2]/div[2]/a[1]")).Click();
            driver.FindElement(By.ClassName("search-btn")).Click();

        }


        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
