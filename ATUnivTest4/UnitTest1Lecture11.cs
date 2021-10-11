using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;



namespace ATUnivTest4
{
    [TestClass]
    public class Lecture11
    {
        IWebDriver driver = new ChromeDriver(@"c:\users\Public\Downloads");
        

        [TestInitialize]
        public void SetUp()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void SelectCheckbox()
        {
            driver.Navigate().GoToUrl(@"https://demoqa.com/checkbox");

            IWebElement drpBox = driver.FindElement(By.CssSelector("#tree-node > ol > li > span > button > svg"));
            drpBox.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement chkBox = driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(2) > span > label > span.rct-checkbox > svg"));
            chkBox.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement chkBox2 = driver.FindElement(By.CssSelector("#tree-node > ol > li > ol > li:nth-child(3) > span > label > span.rct-checkbox > svg"));
            chkBox2.Click();
            System.Threading.Thread.Sleep(3000);

        }

        [TestMethod]
        public void SelectRadioBtn()
        {
            driver.Navigate().GoToUrl(@"https://demoqa.com/radio-button");

            IWebElement yesBtn = driver.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div:nth-child(2) > label"));
            yesBtn.Click();
            System.Threading.Thread.Sleep(3000);
            IWebElement impBtn = driver.FindElement(By.CssSelector("#app > div > div > div.row > div.col-12.mt-4.col-md-6 > div:nth-child(1) > div:nth-child(3) > label"));
            impBtn.Click();
            System.Threading.Thread.Sleep(3000);

        }

        [TestMethod]
        public void emailAssert()
        {
            driver.Navigate().GoToUrl(@"https://demoqa.com/webtables");
            String innerText = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[1]/div[3]/div[1]/div[2]/div[1]/div/div[4]")).GetAttribute("innerText");
            Console.WriteLine(innerText);
            Assert.AreEqual(innerText, "cierra@example.com");
        }

        [TestMethod]
        public void drpDwnAssert()
        {
            driver.Navigate().GoToUrl(@"https://demoqa.com/select-menu");

            //select 2nd element and assert any value was selected
            IWebElement selectValue = driver.FindElement(By.Id("react-select-2-input"));
            selectValue.SendKeys("Group 1, option 2");
            selectValue.SendKeys(Keys.Return);
            Assert.IsNotNull(selectValue);
            System.Threading.Thread.Sleep(3000);

            IWebElement selectTitle = driver.FindElement(By.Id("react-select-3-input"));
            selectTitle.SendKeys("Mr.");
            selectTitle.SendKeys(Keys.Return);
           // Assert.IsNotNull(selectTitle);
            System.Threading.Thread.Sleep(3000);

            IWebElement oldSelectMenu = driver.FindElement(By.Id("oldSelectMenu"));
            oldSelectMenu.SendKeys("Blue");
            oldSelectMenu.SendKeys(Keys.Return);
            System.Threading.Thread.Sleep(3000);

            IWebElement StdMultSel = driver.FindElement(By.CssSelector("#cars > option:nth-child(2)"));
            StdMultSel.Click();

            System.Threading.Thread.Sleep(3000);
        }

       [TestCleanup]
          public void TearDown()
          {
              driver.Quit();
          } 
    }
}

