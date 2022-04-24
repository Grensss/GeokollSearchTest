using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeokollSearchTest
{
    public class WaitUntil
    {
        protected IWebDriver driver;
        public static void WaitForElement(IWebDriver driver, By locator, int sec = 20) 
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(sec)).Until(ExpectedConditions.ElementToBeClickable(locator)); 
           
        }
        public static void ExistanceOfElement(IWebDriver driver, By locator, int sec = 20) 
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(sec)).Until(ExpectedConditions.ElementExists(locator));
        }
        public static void CheckUrl(IWebDriver driver, string locator, int sec = 20) 
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(sec)).Until(ExpectedConditions.UrlContains(locator));
        }
    }
}
