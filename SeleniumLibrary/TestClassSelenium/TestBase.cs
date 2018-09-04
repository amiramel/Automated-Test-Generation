using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassSelenium
{
    public class TestBase
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); // Lounches browser
            driver.Manage().Window.Maximize(); // Maximizes browser
            
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Quit();
        }

    }
}
