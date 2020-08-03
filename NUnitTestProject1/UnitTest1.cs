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
            //driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Navigate().GoToUrl("http://www.durgambabooking.com/");    

        }

        [Test]
        public void Test1()
        {
            /*//Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform ops
            element.SendKeys("test");
            element.SendKeys(Keys.Enter);*/
            driver.FindElement(By.XPath(".//img[@title='click to close']")).Click();

            driver.FindElement(By.Id("triptype_roundtrip")).Click();
            driver.FindElement(By.XPath(".//a[@class='chosen-single']")).Click();
            IWebElement FromPlace= driver.FindElement(By.XPath(".//input[@type='text']"));
            FromPlace.SendKeys("Mysore");
            FromPlace.SendKeys(Keys.Enter);

            driver.FindElement(By.XPath("//div[@id='searchbus_to_chosen']/a/span")).Click();
            IWebElement ToPlace = driver.FindElement(By.XPath(".//div[@id='searchbus_to_chosen']/div/div/input"));
            ToPlace.SendKeys("Mangalore");
            ToPlace.SendKeys(Keys.Enter);

            driver.FindElement(By.Id("searchbus_depart")).Click();
            driver.FindElement(By.XPath(".//a[contains(text(),'12')]")).Click();

            driver.FindElement(By.Id("searchbus_return")).Click();
            driver.FindElement(By.XPath(".//div[@id='ui-datepicker-div']/div/table/tbody/tr[3]/td[4]/a")).Click();

            driver.FindElement(By.Name("commit")).Click();

        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }

    }
}