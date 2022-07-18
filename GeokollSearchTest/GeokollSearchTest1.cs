using GeokollSearchTest.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace GeokollSearchTest
{

    public class GeokollSearchTest1 : BaseClass
    {
        [Test]
        public void Test1()
        {
            var mainPage = new MainMenuPageObject(driver);
            var ProductAssert = new AssertClass(driver);
            
            mainPage.Search(MainMenuPageObject.BNLG25TextName);
            ProductAssert.AssertProductBNLG25();
            mainPage.BNLG25();
            ProductAssert.PriceCheckBNLG25();
        }
    }

    public class GeokollTest : BaseClass
    {
        [Test]
        public void Test2() 
        {
            var mainPage = new MainMenuPageObject(driver);
            var ProductAssert = new AssertClass(driver);
            
            mainPage.Search(MainMenuPageObject.FEPC5TextName)
                    .FEPC5();
            ProductAssert.PriceCheckFEPC5();
        }
    }

    public class SearchOnPageTest : BaseClass
    {
        [Test]
        public void Test3() 
        {
            var mainPage = new MainMenuPageObject(driver);
            var ProductAssert = new AssertClass(driver);
            
            mainPage.Finder();
            ProductAssert.PriceCheckGLA25();
        }
    }

}

    
