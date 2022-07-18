using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeokollSearchTest
{
    internal class AssertClass
    {
        private IWebDriver driver;
        public AssertClass(IWebDriver driver) 
        {
            this.driver = driver;
        }

        private readonly By ProductPrice = By.XPath("//p[@class = 'lead text-muted mb-3']");
        private readonly By ProductBNLG25 = By.XPath("//h5[@class= 'card-title mw-300'][contains(text(),'Biogel No Limits Grey 25 kg')]");
        
        public const string BNLG25TextName = "Biogel No Limits Grey 25 kg";



        public AssertClass AssertProductBNLG25()
        {
            WaitUntil.ExistanceOfElement(driver, ProductBNLG25);
            var TitleText = driver.FindElement(ProductBNLG25);
            Assert.AreEqual(BNLG25TextName, TitleText.Text);

            return new AssertClass(driver);
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
