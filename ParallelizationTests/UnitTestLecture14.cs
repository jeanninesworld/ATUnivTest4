using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ParallelizationTests
{
    [TestFixture]

    public class Tests
    {
            

        [Test]
        public void purchaseModel()
        {
            IWebDriver driver;
            driver = new ChromeDriver(@"c:\users\Public\Downloads");
            driver.Navigate().GoToUrl("http://tailspintoys.azurewebsites.net");
            driver.FindElement(By.CssSelector("#model > a")).Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div[1]/ul/li[3]/p[2]/a")).Click(); driver.FindElement(By.ClassName("add-cart")).Click();
            driver.FindElement(By.ClassName("checkout")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("Jeannine");
            driver.FindElement(By.Id("LastName")).SendKeys("Kwasnik");
            driver.FindElement(By.Id("Email")).SendKeys("j@j.com");
            driver.FindElement(By.Id("Street1")).SendKeys("111");
            driver.FindElement(By.Id("Street2")).SendKeys("Street 2");
            driver.FindElement(By.Id("City")).SendKeys("Oldsmar");
            SelectElement country = new SelectElement(driver.FindElement(By.Id("countrySelect")));
            country.SelectByValue("US");
            SelectElement state = new SelectElement(driver.FindElement(By.Id("stateSelect")));
            state.SelectByValue("FL");
            driver.FindElement(By.Id("Zip")).SendKeys("34677");
            driver.FindElement(By.CssSelector("#bdy > div.product-wrapper > div.product-detail > div > form > input")).Click();
            driver.FindElement(By.CssSelector("#bdy > div.product-wrapper > div.product-detail > div > form > input")).Click();
            IWebElement ReceiptText = driver.FindElement(By.CssSelector("#bdy > h1 > cufon:nth-child(1) > cufontext"));

            Assert.IsNotEmpty(ReceiptText.ToString());


            driver.Quit();
        }
        [Test]
        public void PurchasePaper()
        {
            IWebDriver driver;
            driver = new ChromeDriver(@"c:\users\Public\Downloads");
            driver.Navigate().GoToUrl("http://tailspintoys.azurewebsites.net");
            driver.FindElement(By.CssSelector("#paper > a")).Click();
            driver.FindElement(By.CssSelector("body > div.master > div > div.content > div > div.product-wrapper > ul > li:nth-child(1) > p:nth-child(4) > a")).Click();
            driver.FindElement(By.ClassName("add-cart")).Click();
            driver.FindElement(By.ClassName("checkout")).Click();
            driver.FindElement(By.Id("FirstName")).SendKeys("Jeannine");
            driver.FindElement(By.Id("LastName")).SendKeys("Kwasnik");
            driver.FindElement(By.Id("Email")).SendKeys("j@j.com");
            driver.FindElement(By.Id("Street1")).SendKeys("111");
            driver.FindElement(By.Id("Street2")).SendKeys("Street 2");
            driver.FindElement(By.Id("City")).SendKeys("Oldsmar");
            SelectElement country = new SelectElement(driver.FindElement(By.Id("countrySelect")));
            country.SelectByValue("US");
            SelectElement state = new SelectElement(driver.FindElement(By.Id("stateSelect")));
            state.SelectByValue("FL");
            driver.FindElement(By.Id("Zip")).SendKeys("34677");
            driver.FindElement(By.CssSelector("#bdy > div.product-wrapper > div.product-detail > div > form > input")).Click();
            driver.FindElement(By.CssSelector("#bdy > div.product-wrapper > div.product-detail > div > form > input")).Click();
            IWebElement ReceiptText = driver.FindElement(By.CssSelector("#bdy > h1 > cufon:nth-child(1) > cufontext"));

            Assert.IsNotEmpty(ReceiptText.ToString());

            driver.Quit();
        }
    }
    [TestFixture]
    public class AssemblySetup
    {

    }
}