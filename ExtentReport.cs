using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Threading;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace TestProject2
{
    public class ExtentReport
    {

        IWebDriver driver=null;
        ExtentReports extent=null;
       
        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlReport = new ExtentHtmlReporter(@"C:\Users\Surya\source\repos\TestProject2\TestProject2\Extentreports\DropDownBox.html");
            extent.AttachReporter(htmlReport);
        }
        [OneTimeTearDown]
        public void ExtentEnd()
        {
            extent.Flush();
        }


        [Test]
        public void Test1()

        {
           ExtentTest test=extent.CreateTest("Test1").Info("test started");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            extent.CreateTest("Test1").Info("test started");
            test.Log(Status.Info, "chrome launched");
            driver.Navigate().GoToUrl("https://en-gb.facebook.com/");          
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement dropDown = driver.FindElement(By.XPath("(//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy'])"));
            dropDown.Click();
            IWebElement monthDropDown = driver.FindElement(By.XPath("//*[@id='month']"));
            monthDropDown.Click();
            SelectElement element = new SelectElement(monthDropDown);
            element.SelectByIndex(0);
            element.SelectByText("Aug");
            element.SelectByValue("11");
            driver.Quit();
            test.Log(Status.Pass, "chrome launched");
        }
       
    }

}