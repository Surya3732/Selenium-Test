using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Threading;

namespace TestProject1
{
   public class DataDriven
    {
        IWebDriver driver;
        [Test]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(string urlName)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = urlName;
            driver.Quit();

        }
        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.youtube.com/");
            list.Add("https://www.facebook.com/");
            list.Add("https://www.gmail.com/");
            return list;
        }
    }
}
