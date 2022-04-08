using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeokollSearchTest.PageObject
{
    internal class BiogelNoLimitsGrey25kgPageObject
    {
        private IWebDriver driver;

        private readonly By BNLG25Price = By.XPath("//p[@class = 'lead text-muted mb-3']");

        public BiogelNoLimitsGrey25kgPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BiogelNoLimitsGrey25kgPageObject PriceCheck() 
        {
            var Price = driver.FindElement(BNLG25Price);
            var ExpextedPrice = "€ 22.15";
            Assert.AreEqual(ExpextedPrice, Price.Text);

            return new BiogelNoLimitsGrey25kgPageObject(driver);
        }

    }
}
