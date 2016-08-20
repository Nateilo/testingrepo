using System;
using TechTalk.SpecFlow;

namespace MyProject
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have navigated to the ASOS login page")]
        public void GivenIHaveNavigatedToTheASOSLoginPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I provide valid login details")]
        public void GivenIProvideValidLoginDetails()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I successfully login to the website")]
        public void ThenISuccessfullyLoginToTheWebsite()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
