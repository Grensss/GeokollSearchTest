using GeokollSearchTest.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace GeokollSearchTest
{

    public class GeokollSearchTest1 : BaseClass
    {
        [Test]
        public void ProductExistCheck()
        {
            var mainPage = new MainMenuPageObject(driver);
            mainPage
                .Search(MainMenuPageObject.BNLG25TextName)
                .AssertProductBNLG25()
                .BNLG25();
            var BNLG25Page = new ProductPageObject(driver);
            BNLG25Page
                .PriceCheckBNLG25();
        }
    }

    public class GeokollSuckTest : BaseClass
    {
        [Test]
        public void Test() //Product price check
        {
            var mainPage = new MainMenuPageObject(driver);
            mainPage
                .Search(MainMenuPageObject.FEPC5TextName)
                .FEPC5();
            var FEPC5Page = new ProductPageObject(driver);
            FEPC5Page
                .PriceCheckFEPC5();
        }
    }

}

    
