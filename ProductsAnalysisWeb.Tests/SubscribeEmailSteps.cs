using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;
using Xunit.Abstractions;

namespace ProductsAnalysisWeb.Tests
{
    [Binding]
    public class SubscribeEmailSteps
    {
        private IWebDriver _driver;
        private ContactPage _contactPage;
        private ConfirmationPage _confirmationPage;
        private readonly ITestOutputHelper _output;

        [Given(@"I am on the Contact page for subscriber")]
        public void GivenIAmOnTheContactPageForSubscriber()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _contactPage = ContactPage.NavigateTo(_driver);
        }


        [Given(@"I have entered (.*) in Email field")]
        public void GivenIHaveEnteredHanna_OstapenkoGmail_ComInEmailField(string email)
        {
            _contactPage.SubscriberEmail = email;
        }
        
        [When(@"I press Join")]
        public void WhenIPressJoin()
        {
            _confirmationPage = _contactPage.SubmitEmail();
        }
        [Then(@"I should see ""(.*)"" text on the page")]
        public void ThenIShouldSeeTextOnThePage(string subscriberValidation)
        {
            _output.WriteLine("Expected - " + subscriberValidation + "\nActual - " + _confirmationPage.Message);
            Assert.Equal(subscriberValidation, _confirmationPage.Message);
        }

    }
}
