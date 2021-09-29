using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Threading;
namespace TestProject1
{
    public class Category
    {
        
        
            IWebDriver driver;

            [SetUp]
            public void Setup()
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            [Test, Category("SmokeTesting")]
            public void Test1()

            {

                driver.Navigate().GoToUrl("https://en-gb.facebook.com/");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.Name("email")).SendKeys("surya");
                driver.FindElement(By.Name("pass")).SendKeys("surya");
                driver.FindElement(By.XPath("(//*[@name='login'])")).Click();
                Thread.Sleep(1000);
            }
            [Test, Category("RegressionTesting")]
            public void Test2()
            {
                driver.Navigate().GoToUrl("https://en-gb.facebook.com/");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.Name("email")).SendKeys("surya");
                driver.FindElement(By.Name("pass")).SendKeys("surya");
                driver.FindElement(By.XPath("(//*[@name='login'])")).Click();
                Thread.Sleep(1000);

            }
            [TearDown]
            public void TearDownMethod()
            {
                driver.Quit();
            }
        
    }
}
