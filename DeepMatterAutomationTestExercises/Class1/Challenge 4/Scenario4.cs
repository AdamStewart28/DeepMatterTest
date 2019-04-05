using System;
using System.IO;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestExercises.Challenge4
{
    public class Scenario4
    {
        [Test]
        public void Test()
        {
            // Opening the browser to Google and maximising the window
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();

            // Navigating to the deepmatter website
            webDriver.Navigate().GoToUrl("https://www.deepmatter.io");

            // Navigating to the "How It Works" section of the page
            webDriver.FindElement(By.CssSelector("[href*='#how-it-works']")).Click();

            //Taking a screenshot of the "How It Works" section
            Thread.Sleep(2000);
            ((ITakesScreenshot)webDriver).GetScreenshot().SaveAsFile("TestScreenshot.jpeg", ScreenshotImageFormat.Jpeg);
            webDriver.Quit();
        }
    }
}
