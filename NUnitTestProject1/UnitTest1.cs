using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace NUnitTestProject1
{
    public class Tests
    {
        //Create the reference for our browser
        IWebDriver driver = new FirefoxDriver();

        [SetUp]
        public void Setup()
        {
            //Navigate to Google Page
            driver.Navigate().GoToUrl("https://www.google.com/");

        }

        [Test]
        public void Test1()
        {
            //Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform ops
            element.SendKeys("test");
            element.SendKeys(Keys.Enter);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }

    }
}