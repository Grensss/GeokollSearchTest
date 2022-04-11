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

        private readonly By FEPC5Price = By.XPath("//p[@class = 'lead text-muted mb-3']");

        public FugabellaEcoPorcelana0_8Classic5kgPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void PriceCheckFEPC5() 
        {
            var Price = driver.FindElement(FEPC5Price);
            var ExpextedPrice = "€ 15.1";
            Assert.AreEqual(ExpextedPrice, Price.Text);   
        }
    }
}
