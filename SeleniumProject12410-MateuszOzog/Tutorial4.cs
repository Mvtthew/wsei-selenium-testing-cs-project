using System;
using System.Collections;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumProject12410_MateuszOzog
{
    public class Tutorial4
    {
        [Test]
        [Author("Mateusz", "mateusz.ozog@microsoft.wsei.edu.pl")]
        [Description("Facebook register Verify")]
        public void Test1()
        {
            IWebDriver driver = null;
            try
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

                IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
                //IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstnamasde]"));
                emailTextField.SendKeys("Selenium");

                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("/Users/mat/Desktop/SeleniumProject12410-MateuszOzog/SeleniumProject12410-MateuszOzog/Screenshots/1.png", ScreenshotImageFormat.Png);

                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }

        [Test]
        [Author("Mateusz", "mateusz.ozog@microsoft.wsei.edu.pl")]
        [Description("Date driver Verify")]
        [TestCaseSource("DataDriverTesting")]
        public void Test2(String urlName)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = urlName;

            driver.Quit();
        }

        static IList DataDriverTesting()
        {
            ArrayList list = new ArrayList();

            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.gmail.com/");

            return list;
        }


        //[Test]
        //[Author("Mateusz", "mateusz.ozog@microsoft.wsei.edu.pl")]
        //[Description("Facebook register Verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url = "https://www.facebook.com/";
        //    Thread.Sleep(1000);
        //    IWebElement cookieAcceptButton = driver.FindElement(By.CssSelector("[data-testid=cookie-policy-manage-dialog-accept-button]"));
        //    IWebElement registerButton = driver.FindElement(By.CssSelector("[data-testid=open-registration-form-button]"));
        //    // First accept cookies
        //    cookieAcceptButton.Click();
        //    Thread.Sleep(500);
        //    // Then launch register modal
        //    registerButton.Click();
        //    Thread.Sleep(500);

        //    IWebElement emailTextField = driver.FindElement(By.CssSelector("[name=firstname]"));
        //    emailTextField.SendKeys("Selenium");

        //    driver.Quit();
        //}
    }
}
