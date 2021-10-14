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
        [TestCategory("SearchTest")]

        public void searchTest()
        {
            driver.Navigate().GoToUrl(@"http://www.google.com");
            var search = driver.FindElement(By.Name("q"));
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\MySearch.txt");
            search.SendKeys(text);
            search.SendKeys(Keys.Return);
        }

        [TestMethod]
        [TestCategory("MediaTest")]
        [TestCategory("RegressionTests")]
        public void LinkedIn()
        {
            driver.Navigate().GoToUrl(@"http://www.agilethought.com");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement linkedInBtn = driver.FindElement(By.CssSelector("body > div.elementor.elementor-2049.elementor-location-footer > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-e0b10f9.elementor-section-content-middle.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-a5eb352 > div > div > div.elementor-element.elementor-element-c4f876b.elementor-shape-circle.e-grid-align-left.elementor-grid-0.elementor-widget.elementor-widget-social-icons > div > div > span:nth-child(1) > a > i"));
            String btn = ("arguments[0].click();'linkedInBtn'");
            jse.ExecuteScript(btn, linkedInBtn);
            string title = (driver.SwitchTo().Window(driver.WindowHandles[1]).Title);
            System.Threading.Thread.Sleep(5000);
            Assert.AreEqual(title, "Sign In | LinkedIn");
        }

        [TestMethod]
        [TestCategory("MediaTest")]
        [TestCategory("RegressionTests")]
        public void FaceBook()
        {
            driver.Navigate().GoToUrl(@"http://www.agilethought.com");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement FacebookBtn = driver.FindElement(By.CssSelector("body > div.elementor.elementor-2049.elementor-location-footer > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-e0b10f9.elementor-section-content-middle.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-a5eb352 > div > div > div.elementor-element.elementor-element-c4f876b.elementor-shape-circle.e-grid-align-left.elementor-grid-0.elementor-widget.elementor-widget-social-icons > div > div > span:nth-child(2) > a > i"));
            String btn = ("arguments[0].click();'FacebookBtn'");
            jse.ExecuteScript(btn, FacebookBtn);
            string title = (driver.SwitchTo().Window(driver.WindowHandles[1]).Title);
            Assert.AreEqual(title, "AgileThought - Home | Facebook");
        }

        [TestMethod]
        [TestCategory("MediaTest")]
        [TestCategory("RegressionTests")]
        public void Instagram()
        {
            driver.Navigate().GoToUrl(@"http://www.agilethought.com");
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement instagramBtn = driver.FindElement(By.CssSelector("body > div.elementor.elementor-2049.elementor-location-footer > div > section.elementor-section.elementor-top-section.elementor-element.elementor-element-e0b10f9.elementor-section-content-middle.elementor-section-boxed.elementor-section-height-default.elementor-section-height-default > div > div > div.elementor-column.elementor-col-50.elementor-top-column.elementor-element.elementor-element-a5eb352 > div > div > div.elementor-element.elementor-element-c4f876b.elementor-shape-circle.e-grid-align-left.elementor-grid-0.elementor-widget.elementor-widget-social-icons > div > div > span:nth-child(4) > a > i"));
            String btn = ("arguments[0].click();'instagramBtn'");
            jse.ExecuteScript(btn, instagramBtn);
            string title = (driver.SwitchTo().Window(driver.WindowHandles[1]).Title);
            System.Threading.Thread.Sleep(5000);
            Assert.AreEqual(title, "AgileThought (@agilethought) • Instagram photos and videos");
            
        }

        [TestMethod]
        [TestCategory("SearchTest")]
        [TestCategory("RegressionTests")]
        public void Amazon()
        {
            driver.Navigate().GoToUrl(@"http://www.amazon.com");
            var search = driver.FindElement(By.Id("twotabsearchtextbox"));
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\Documents\MySearch2.txt");
            search.SendKeys(text);
            search.SendKeys(Keys.Return);
            
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
