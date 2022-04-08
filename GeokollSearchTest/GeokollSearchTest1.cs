using GeokollSearchTest.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace GeokollSearchTest
{

    public class GeokollSearchTest1
    {
        private IWebDriver driver; 

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://geokoll.lv/lv");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ProductExistCheck()
        {
            var mainPage = new MainMenuPageObject(driver);
            mainPage
                .Search(MainMenuPageObject.SearchProduct)
                .AssertProductBNLG25()
                .BNLG25();
            var BNLG25Page = new BiogelNoLimitsGrey25kgPageObject(driver);
            BNLG25Page
                .PriceCheck();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();

        }
    }

    public class GeokollSuckTest
    {
        private IWebDriver driver;

        private readonly By SearchButton = By.XPath("//i[@class = 'fa fa-search']");
        private readonly By SearchBox = By.XPath("//input[@name = 'q']");
        private readonly By ProductPrice = By.XPath("//span[@class='lead']");

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://geokoll.lv/lv");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test() //Product price check
        {
            var SearchProduct = driver.FindElement(SearchBox);
            SearchProduct.SendKeys("Fugabella Eco Porcelana 0-8 Classic 5 kg");

            var searchbutton = driver.FindElement(SearchButton);
            searchbutton.Click();
            
            var Price = driver.FindElement(ProductPrice);

            var ExpextedPrice = "15.1";

            Assert.AreEqual(ExpextedPrice, Price.Text);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }




}

    
