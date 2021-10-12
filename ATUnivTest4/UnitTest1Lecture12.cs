using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;

namespace ATUnivTest4
{
    [TestClass]
    public class Lecture12
    {
        
        IWebDriver driver = new ChromeDriver(@"c:\users\Public\Downloads");                   


    [TestInitialize]
        public void SetUp()
        {
            driver.Navigate().GoToUrl(@"https://www.c-sharpcorner.com/register");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Window.Maximize();
            
        } 
        
        
        [TestMethod]
        public void javaScriptExecution()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

            IWebElement enterEmail = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxEmail"));
            String email = ("arguments[0].value='jk@test.com'");
            jse.ExecuteScript(email, enterEmail);

            IWebElement enterFirst = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxFirstName"));
            String firstName = ("arguments[0].value='Jeannine'");
            jse.ExecuteScript(firstName, enterFirst);

            IWebElement enterLast = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxLastName"));
            String lastName = ("arguments[0].value='Kwasnik'");
            jse.ExecuteScript(lastName, enterLast);

            IWebElement enterPass = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxPassword"));
            String password = ("arguments[0].value='Password'");
            jse.ExecuteScript(password, enterPass);

            IWebElement confirmPass = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxPasswordConfirm"));
            String confirmPassword = ("arguments[0].value='Password'");
            jse.ExecuteScript(confirmPassword, confirmPass);

            IWebElement enterCountry = driver.FindElement(By.Name("ctl00$ContentMain$DropdownListCountry"));
            String country = ("arguments[0].value='United States'");
            jse.ExecuteScript(country, enterCountry);

            IWebElement enterZip = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxZip"));
            String zip = ("arguments[0].value='34677'");
            jse.ExecuteScript(zip, enterZip);

            IWebElement enterCity = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxCity"));
            String city = ("arguments[0].value='Oldsmar'");
            jse.ExecuteScript(city, enterCity);

            IWebElement selQuestion = driver.FindElement(By.Name("ctl00$ContentMain$DropdownListSecurityQuesion"));
            String question = ("arguments[0].value='2'");
            jse.ExecuteScript(question, selQuestion);

            IWebElement enterAnswer = driver.FindElement(By.Name("ctl00$ContentMain$TextBoxAnswer"));
            String answer = ("arguments[0].value='MyPet'");
            jse.ExecuteScript(answer, enterAnswer);

            IWebElement acceptTerms = driver.FindElement(By.Name("ctl00$ContentMain$cbxIsGDPRAccepted"));
            String accept = ("arguments[0].click();'cbxIsGDPRAccepted'");
            jse.ExecuteScript(accept, acceptTerms);

            jse.ExecuteScript("window.scrollBy(0,1000)");

            IWebElement registerMe = driver.FindElement(By.Name("ctl00$ContentMain$ButtonSave"));
            String register = ("arguments[0].click();'Register Me'");
            jse.ExecuteScript(register, registerMe);

            System.Threading.Thread.Sleep(3000);
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }

        private IWebDriver IJavaScriptExecutor()
        {
            throw new NotImplementedException();
        }
    }
}
