using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace GeokollSearchTest
{

    public class GeokollSearchTest1
    {
        private IWebDriver driver;
        private readonly By SearchInputSpace = By.XPath("//input[@name = 'q']");
        private readonly By SearchAfterInputButton = By.XPath("//i[@class = 'fa fa-search']");

        private readonly By Title = By.XPath("//h5[contains(text(),'Grey')]");
        
        private const string SearchProduct = "Biogel No Limits Grey 25 kg";
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://geokoll.lv/lv");
            driver.Manage().Window.Maximize();
        }
        
        [Test]
        public void Test1()
        {
            var SearchSpace = driver.FindElement(SearchInputSpace);
            SearchSpace.SendKeys(SearchProduct);
            
            var SearchButton = driver.FindElement(SearchAfterInputButton);
            SearchButton.Click();

            var TitleText = driver.FindElement(Title);
            
            Assert.AreEqual(SearchProduct ,TitleText.Text);
            
        }
        [TearDown]

        public void TearDown()
        {
            driver.Quit();

        }
     

    }
}