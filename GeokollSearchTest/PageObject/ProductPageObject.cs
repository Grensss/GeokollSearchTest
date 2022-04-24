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

        private readonly By BNLG25Price = By.XPath("//p[@class = 'lead text-muted mb-3']");
        private readonly By FEPC5Price = By.XPath("//p[@class = 'lead text-muted mb-3']");

        public ProductPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PriceCheckBNLG25() 
        {
            WaitUntil.ExistanceOfElement(driver, BNLG25Price);
            var Price = driver.FindElement(BNLG25Price);
            var ExpextedPrice = "€ 22.15";
            Assert.AreEqual(ExpextedPrice, Price.Text);
        }
        public void PriceCheckFEPC5()
        {
            WaitUntil.ExistanceOfElement(driver, FEPC5Price); 
            var Price = driver.FindElement(FEPC5Price);
            var ExpextedPrice = "€ 15.1";
            Assert.AreEqual(ExpextedPrice, Price.Text);
        }

    }
}
