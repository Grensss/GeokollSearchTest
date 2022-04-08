using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeokollSearchTest.PageObject
{
    internal class MainMenuPageObject
    {
        private IWebDriver driver;
        private readonly By SearchBox = By.XPath("//input[@name = 'q']");
        private readonly By SearchButton = By.XPath("//i[@class = 'fa fa-search']");
        private readonly By ProductBNLG25 = By.XPath("//h5[@class= 'card-title mw-300'][contains(text(),'Biogel No Limits Grey 25 kg')]");
        
        public const string SearchProduct = "Biogel No Limits Grey 25 kg";

        
        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        public MainMenuPageObject Search(string searchtag) 
        {
            driver.FindElement(SearchBox).SendKeys(searchtag);
            driver.FindElement(SearchButton).Click();
           
            return new MainMenuPageObject(driver);
        }
        public MainMenuPageObject AssertProductBNLG25()
        {
            var TitleText = driver.FindElement(ProductBNLG25);
            Assert.AreEqual(SearchProduct, TitleText.Text);

            return new MainMenuPageObject(driver);
        }



        public BiogelNoLimitsGrey25kgPageObject BNLG25()
        {
            driver.FindElement(ProductBNLG25).Click();

            return new BiogelNoLimitsGrey25kgPageObject(driver);
        }


        

    }
}
