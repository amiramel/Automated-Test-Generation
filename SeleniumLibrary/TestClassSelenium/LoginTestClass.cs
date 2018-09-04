using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit;
using NUnit.Framework;

namespace TestClassSelenium
{
   
    [TestFixture]
    public class LoginTestClass : TestBase
    {
        [Test]
        public void VerifyValidLogin()
        {
            //Open site
            driver.Url = "http://manage.zapbeta.co.il/web/sites-login.aspx";

            //Enter Username and password
            driver.FindElement(By.Id("iEmail")).SendKeys("amiram");
            driver.FindElement(By.Id("iPassword")).SendKeys("amiram123");
            //Click on Login button
            driver.FindElement(By.Id("btnGoLogin")).Click();
        }

        [Test]
        public void VerifyInvalidLogin()
        {
            //Open site
            driver.Url = "http://manage.zapbeta.co.il/web/sites-login.aspx";

            //Enter wrong Username and password 
            driver.FindElement(By.Id("iEmail")).SendKeys("test");
            driver.FindElement(By.Id("iPassword")).SendKeys("test");
            //Click on Login button
            driver.FindElement(By.Id("btnGoLogin")).Click();
        }
    }

}