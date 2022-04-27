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
        private readonly By NextButton = By.XPath("//a[@class='page-link kerakoll-link'][contains(text(),'Next ')]");

        //Biogel No Limits Grey 25 kg
            private readonly By ProductBNLG25 = By.XPath("//h5[@class= 'card-title mw-300'][contains(text(),'Biogel No Limits Grey 25 kg')]");
        //Fugabella Eco Porcelana 0-8 Classic 5 kg
            private readonly By ProductFEPC5 = By.XPath("//h5[@class= 'card-title mw-300'][contains(text(),'Fugabella Eco Porcelana 0-8 Classic 5 kg')]"); 
        //GeoLite Asfalto 25 kg
            private readonly By ProductGLA25 = By.XPath("//h5[@class='card-title mw-300'][contains(text(),'GeoLite Asfalto 25 kg')]");

        public const string BNLG25TextName = "Biogel No Limits Grey 25 kg";
        public const string FEPC5TextName = "Fugabella Eco Porcelana 0-8 Classic 5 kg";

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        
        public MainMenuPageObject Search(string searchtag) 
        {
            WaitUntil.WaitForElement(driver, SearchBox);
            driver.FindElement(SearchBox).SendKeys(searchtag);
            driver.FindElement(SearchButton).Click();
            
           
            return new MainMenuPageObject(driver);
        }
        public MainMenuPageObject AssertProductBNLG25()
        {
            WaitUntil.ExistanceOfElement(driver, ProductBNLG25);
            var TitleText = driver.FindElement(ProductBNLG25);
            Assert.AreEqual(BNLG25TextName, TitleText.Text);

            return new MainMenuPageObject(driver);
        }



        public ProductPageObject BNLG25()
        {
            WaitUntil.WaitForElement(driver, ProductBNLG25);
            driver.FindElement(ProductBNLG25).Click();

            return new ProductPageObject(driver);
        }
        public ProductPageObject FEPC5() 
        {
            WaitUntil.WaitForElement(driver, ProductFEPC5);
            driver.FindElement(ProductFEPC5).Click();

            return new ProductPageObject(driver);
        }
        public bool ProductCheckOnPage()
        {
            try
            {
                driver.FindElement(ProductGLA25);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public MainMenuPageObject Finder() 
        {
            if (ProductCheckOnPage() == true)
            {
                driver.FindElement(ProductGLA25).Click();
            }
            else 
            {
                driver.FindElement(NextButton).Click();
                Finder();
            }

            return new MainMenuPageObject(driver);
        }




    }
}
