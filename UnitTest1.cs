using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace NUnitTestGoogle
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}