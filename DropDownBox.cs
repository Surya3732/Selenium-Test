using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Threading;

namespace TestProject1
{
    public class DropDownBox
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

            driver.Navigate().GoToUrl("https://en-gb.facebook.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);          
            IWebElement dropDown=driver.FindElement(By.XPath("(//*[@class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy'])"));
            dropDown.Click();
            IWebElement monthDropDown= driver.FindElement(By.XPath("//*[@id='month']"));
            monthDropDown.Click();
            SelectElement element = new SelectElement(monthDropDown);
            element.SelectByIndex(0);
            element.SelectByText("Aug");
            element.SelectByValue("11");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
    
}

