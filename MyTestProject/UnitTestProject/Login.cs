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
    public class Login
    {
        private string baseURL = "https://www.asos.com/";
        private RemoteWebDriver driver;
        private string browser;
        [Given(@"I have opened the ASOS website")]
        public void GivenIHaveOpenedTheASOSWebsite()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElementById("search - box").Clear();
            driver.FindElementById("search - box").SendKeys("tire");
        }
        
        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I tap the login button")]
        public void WhenITapTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I provide valid login details")]
        public void WhenIProvideValidLoginDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

