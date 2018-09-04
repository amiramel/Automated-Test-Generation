using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace MySeleniumWebDriver
{
    public class MyTestClass
    {
        private IWebDriver webDriver;
        [SetUp]
        public void InitDriver(IWebDriver webDriver)
        {
            webDriver = new ChromeDriver();
        }
        [Test]
        public void GoToGoogle()
        {
            webDriver.Url = "www.google.com";
        }
        [TearDown]
        public void Close()
        {
            webDriver.Quit();
        }
    }


   
}
