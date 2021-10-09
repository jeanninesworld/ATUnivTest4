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
        public void SearchPrintToConsole()
        {
            driver.Navigate().GoToUrl(@"https://www.takemefishing.org/");
            IWebElement searchIcon = driver.FindElement(By.CssSelector("#nav-search > div"));
            searchIcon.Click();
            IWebElement searchBox = driver.FindElement(By.Id("gsc-i-id1"));
            searchBox.SendKeys("Snook Fishing");
            searchBox.SendKeys(Keys.Enter);


            var listLinks = driver.FindElements(By.TagName("b"));
                //FindElements(By.ClassName("gs-title"));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(listLinks); 
            }
        }


         [TestCleanup]
          public void TearDown()
          {
              driver.Quit();
          } 

    }
}
