using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TestProject1
{
   public class Exception_Handling
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            try
            {
                driver.Navigate().GoToUrl("https://www.youtube.com/");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.FindElement(By.Name("search_query")).SendKeys("R15v2");
                driver.FindElement(By.Id("search-icon-legacy")).Click();
                Thread.Sleep(1000);
            }
            catch (Exception)
            {
                Screenshot srcFile = ((ITakesScreenshot)driver).GetScreenshot();
                var screenShotPath = @"C:\\Users\\Surya\\source\\repos\\TestProject1\\TestProject1\\screenShot.PNG";
                srcFile.SaveAsFile(screenShotPath);
                Thread.Sleep(5000);
            }
        }
        [TearDown]
        public void TearDownMethod()
        {
            driver.Quit();
        }
    }
}
    

