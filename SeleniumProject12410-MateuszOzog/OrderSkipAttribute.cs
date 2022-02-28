using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace SeleniumProject12410_MateuszOzog
{
    public class OrderSkipAttribute
    {
        [Test, Order(2) ,Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(1000);
            IWebElement cookieAcceptButton = driver.FindElement(By.CssSelector("[data-testid=cookie-policy-manage-dialog-accept-button]"));
            IWebElement registerButton = driver.FindElement(By.CssSelector("[data-testid=open-registration-form-button]"));
            // First accept cookies
            cookieAcceptButton.Click();
            Thread.Sleep(500);
            // Then launch register modal
            registerButton.Click();
            Thread.Sleep(500);

            IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            driver.Close(); 
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(1000);
            IWebElement cookieAcceptButton = driver.FindElement(By.CssSelector("[data-testid=cookie-policy-manage-dialog-accept-button]"));
            IWebElement registerButton = driver.FindElement(By.CssSelector("[data-testid=open-registration-form-button]"));
            // First accept cookies
            cookieAcceptButton.Click();
            Thread.Sleep(500);
            // Then launch register modal
            registerButton.Click();
            Thread.Sleep(500);

            IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            driver.Close();

            Assert.Pass();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(1000);
            IWebElement cookieAcceptButton = driver.FindElement(By.CssSelector("[data-testid=cookie-policy-manage-dialog-accept-button]"));
            IWebElement registerButton = driver.FindElement(By.CssSelector("[data-testid=open-registration-form-button]"));
            // First accept cookies
            cookieAcceptButton.Click();
            Thread.Sleep(500);
            // Then launch register modal
            registerButton.Click();
            Thread.Sleep(500);

            IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            driver.Close();

            Assert.Pass();
        }
    }
}
