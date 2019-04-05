using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestExercises.Challenge5
{
    public class Scenario5
    {
        [Test]
        public void Test()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            // Navigating to the deepmatter website
            webDriver.Navigate().GoToUrl("https://www.deepmatter.io");

            // Navigating to the "Join Us" section of the page
            webDriver.FindElement(By.CssSelector("[href*='#join-us']")).Click();

            // Clicking on the email input box and entering a incorrect format
            Thread.Sleep(2000);
            webDriver.FindElement(By.Name("email")).Click();
            webDriver.FindElement(By.Name("email")).SendKeys("abc123");

            //Clicking on the submit button
            Thread.Sleep(2000);
            webDriver.FindElement(By.CssSelector(".button.sqs-system-button.sqs-editable-button")).Click();

            // Checking the error message is present
            Thread.Sleep(3000);
            webDriver.FindElement(By.ClassName("field-error"));
            webDriver.FindElement(By.XPath("//div[normalize-space()='Email Address is not valid. Email addresses should follow the format user@domain.com.']"));
            webDriver.Quit();
        }
    }
}
