using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;
using System;

namespace UnitTestProject
{
    [Binding]
    public class AddToCart
    {
        private string baseURL = "https://www.asos.com/";
        private RemoteWebDriver driver;
        private string browser;
        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(baseURL);
            IWebElement emailField = driver.FindElementById("EmailAddress");
            emailField.SendKeys("nathe@live.com");
            IWebElement passwordField = driver.FindElementById("Password");
            passwordField.SendKeys("password1");
            driver.FindElementById("signin").Click();
            driver.FindElementById("_ctl0_ContentBody_ctlSecureNav_imgLogo").Click();
        }
        
        [Given(@"I search for a shirt")]
        public void GivenISearchForAShirt()
        {
            IWebElement searchInput = driver.FindElementById("txtSearch");
            searchInput.SendKeys("Shirt");
            searchInput.SendKeys(Keys.Enter);
        }
        
        [Given(@"I select the first item in the list")]
        public void GivenISelectTheFirstItemInTheList()
        {
            driver.FindElementByCssSelector("img.product-img").Click();
        }
        
        [Given(@"I add to my cart")]
        public void GivenIAddToMyCart()
        {
            driver.FindElement(By.Id("ctl00_ContentMainPage_ctlSeparateProduct_drpdwnSize")).FindElement(By.XPath(".//option[contains(text(),'UK 10')]")).Click();
            driver.FindElementById("ctl00_ContentMainPage_ctlSeparateProduct_btnAddToBasket").Click();
        }
        
        [Then(@"I have (.*) item in my cart")]
        public void ThenIHaveItemInMyCart(int p0)
        {
          
        }
    }
}
