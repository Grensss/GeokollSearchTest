using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeokollSearchTest.PageObject
{
    internal class FugabellaEcoPorcelana0_8Classic5kgPageObject
    {
        private IWebDriver driver;

        private readonly By ProductPrice = By.XPath("//p[@class = 'lead text-muted mb-3']");

        public FugabellaEcoPorcelana0_8Classic5kgPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public FugabellaEcoPorcelana0_8Classic5kgPageObject PriceCheck() 
        {
            var Price = driver.FindElement(ProductPrice);
            var ExpextedPrice = "€ 15.1";
            Assert.AreEqual(ExpextedPrice, Price.Text);

            return new FugabellaEcoPorcelana0_8Classic5kgPageObject(driver);
        }
    }
}
