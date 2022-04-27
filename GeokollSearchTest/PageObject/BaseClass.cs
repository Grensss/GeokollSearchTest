using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeokollSearchTest.PageObject
{
    public class BaseClass
    {
        protected IWebDriver driver;
     
        [OneTimeSetUp]
        protected void DoBeforeAllTests()
        {
            driver = new ChromeDriver();
        }
        [TearDown]
        protected void Quit()
        {
            driver.Quit();
        }
        [SetUp]
        protected void DoBeforeEach() 
        {
            driver.Navigate().GoToUrl("https://geokoll.lv/lv");
            driver.Manage().Window.Maximize();
            WaitUntil.CheckUrl(driver, "https://geokoll.lv/lv");
        }


    }
}
