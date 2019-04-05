using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TestExercises.Challenge1
{
    public class Scenario1
    {
        [Test]
        public void Test()
        {
            // Opening the browser to Google and maximising the window
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://www.google.com");

            // Clicking on the search bar and typing "deepmatter" then hitting enter to search
            webDriver.FindElement(By.ClassName("SDkEP")).Click();
            webDriver.FindElement(By.Name("q")).SendKeys("deepmatter" + Keys.Enter);

            // Checking the results page contains the text "deepmatter and checking the link is present"
            webDriver.PageSource.Contains("deepmatter");
            webDriver.PageSource.Contains("https://www.deepmatter.io");
            webDriver.Quit();
        }
    }
}
