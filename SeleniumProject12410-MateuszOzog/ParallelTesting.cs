using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumProject12410_MateuszOzog.BaseClass;
using SeleniumProject12410_MateuszOzog.Utilities;

namespace SeleniumProject12410_MateuszOzog
{
    public class ParallelTests
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        } 

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2() 
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement emailTextField = Driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Driver.Close();

            Assert.Pass();
        }
    }
}
