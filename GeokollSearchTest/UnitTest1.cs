using NUnit.Framework;
using OpenQA.Selenium;

namespace GeokollSearchTest
{

    public class UnitTest1
    {
        private IWebDriver driver;
        private readonly By SearchInputSpace = By.XPath("//input[@name = 'q']");
        private readonly By SearchAfterInputButton = By.XPath("//i[@class = 'fa fa-search']");
        private readonly By ProductName = By.XPath("//h5[@class = 'card-title mw-300']");

        private const string SearchProduct = "biogel no limits grey 25 kg";
        
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://geokoll.lv/lv");
            driver.Manage().Window.Maximize();
        }
        
        [Test]
        public void Test1()
        {
            var SearchSpace = driver.FindElement(SearchInputSpace);
            SearchSpace.Click();
            SearchSpace.SendKeys(SearchProduct);
            
            var SearchButton = driver.FindElement(SearchAfterInputButton);
            SearchButton.Click();
            
            var ProductNameClick = driver.FindElement(ProductName);
            ProductNameClick.Click();   
        }
       
     

    }
}