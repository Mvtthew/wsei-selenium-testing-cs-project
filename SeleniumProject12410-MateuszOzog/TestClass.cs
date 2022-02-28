using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumProject12410_MateuszOzog.BaseClass;

namespace SeleniumProject12410_MateuszOzog
{
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            IWebElement monthDropdown = driver.FindElement(By.CssSelector("[name=birthday_month]"));
            SelectElement monthDropdownElement = new SelectElement(monthDropdown);

            monthDropdownElement.SelectByIndex(1);
            monthDropdownElement.SelectByText("mar");
            monthDropdownElement.SelectByValue("6");

            Assert.Pass();
        }

        [Test, Category("Regresion Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Assert.Pass();
        }

        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
            emailTextField.SendKeys("Selenium");

            Assert.Pass();
        }
    }
}
