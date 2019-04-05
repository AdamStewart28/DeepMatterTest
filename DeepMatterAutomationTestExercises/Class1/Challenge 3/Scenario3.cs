using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestExercises.Challenge3
{
    public class Scenario3
    {
        [Test]
        public void Test()
        {
            // Opening the browser to Google and maximising the window
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            // Navigating to the deepmatter website
            webDriver.Navigate().GoToUrl("https://www.deepmatter.io");

            // Navigating to the "Join Us" section of the page
            webDriver.FindElement(By.CssSelector("[href*='#join-us']")).Click();

            // Clicking on the first name input box and entering first name
            Thread.Sleep(2000);
            webDriver.FindElement(By.Name("fname")).Click();
            webDriver.FindElement(By.Name("fname")).SendKeys("Adam");

            // Clicking on the last name input box and entering last name
            webDriver.FindElement(By.Name("lname")).Click();
            webDriver.FindElement(By.Name("lname")).SendKeys("Stewart");

            //Clicking on the submit button
            Thread.Sleep(2000);
            webDriver.FindElement(By.CssSelector(".button.sqs-system-button.sqs-editable-button")).Click();

            // Checking the error message is present
            Thread.Sleep(3000);
            Assert.IsNotNull(webDriver.FindElement(By.ClassName("field-error")));
            Assert.IsNotNull(webDriver.FindElement(By.XPath("//div[normalize-space()='Email Address is required.']")));
            webDriver.Quit();
        }
    }
}
