using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeokollSearchTest.PageObject
{
    internal class ProductPageObject
    {
        private IWebDriver driver;

        private readonly By ProductPrice = By.XPath("//p[@class = 'lead text-muted mb-3']");

        public ProductPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PriceCheckBNLG25() 
        {
            WaitUntil.ExistanceOfElement(driver, ProductPrice);
            var Price = driver.FindElement(ProductPrice);
            var ExpextedPrice = "€ 22.15";
            Assert.AreEqual(ExpextedPrice, Price.Text);
        }
        public void PriceCheckFEPC5()
        {
            WaitUntil.ExistanceOfElement(driver, ProductPrice); 
            var Price = driver.FindElement(ProductPrice);
            var ExpextedPrice = "€ 15.1";
            Assert.AreEqual(ExpextedPrice, Price.Text);
        }
        public void PriceCheckGLA25()
        {
            WaitUntil.ExistanceOfElement(driver, ProductPrice);
            var Price = driver.FindElement(ProductPrice);
            var ExpextedPrice = "€ 31.3";
            Assert.AreEqual(ExpextedPrice, Price.Text);
        }


    }
}
