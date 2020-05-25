using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace ProductAnalysisWeb.Tests
{

    [Binding]
    public class SendingMessageSteps
    {
        private readonly ScenarioContext context;
        private IWebDriver _driver;
        private ContactPage _contactPage;
        private ConfirmationPage _confirmationPage;

        [Given(@"I am on the Contact page")]
        public void GivenIAmOnTheContactPage()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            //_driver.Navigate().GoToUrl("http://localhost:5001/Contact");
            _contactPage = ContactPage.NavigateTo(_driver);
        }

        [Given(@"I have entered (.*) into the Name field")]
        public void GivenIHaveEnteredHannaIntoTheNameField(string contactName)
        {
            _contactPage.Name = contactName;
        }

        [Given(@"I have entered (.*) into the Phone field")]
        public void GivenIHaveEnteredIntoThePhoneField(string contactPhone)
        {
            _contactPage.Phone = contactPhone;
        }

        [Given(@"I have entered (.*) into the Email field")]
        public void GivenIHaveEnteredDaretaSimcorp_ComIntoTheEmailField(string contactEmail)
        {
            _contactPage.Email = contactEmail;
        }

        [Given(@"I have entered ""(.*)"" into the Message field")]
        public void GivenIHaveEnteredIntoTheMessageField(string message)
        {
            _contactPage.Message = message;
        }

        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            _confirmationPage = _contactPage.SubmitApplication();
        }

        [Then(@"I should see ""(.*)"" text on the screen")]
        public void ThenIShouldSeeTextOnTheScreen(string confirmationText)
        {
            _confirmationPage.Message = confirmationText;
            Assert.Equal(confirmationText, _confirmationPage.Message);
        }


    }
}
