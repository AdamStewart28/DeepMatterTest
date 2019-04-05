using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestExercises.Challenge2
{
    public class Scenario2
    {
        [Test]
        public void Test()
        {
            // Opening the browser to Google and maximising the window
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            // Navigating to the deepmatter website
            webDriver.Navigate().GoToUrl("https://www.deepmatter.io");

            // Searching for the Investor relations element
            webDriver.FindElement(By.XPath("//a[text()='Investor relations ->']"));

            // Checking if the link is the correct one
             Assert.AreEqual(webDriver.FindElement(By.XPath("//a[text()='Investor relations ->']")).GetAttribute("href"), "http://www.deepmattergroup.com/");


            webDriver.Quit();
        }
    }
}
