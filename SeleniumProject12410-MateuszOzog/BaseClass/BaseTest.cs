using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject12410_MateuszOzog.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
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
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
