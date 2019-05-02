using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using Training8A.PageObjects;
using Training8A.Utilities;
using TechTalk.SpecFlow.Assist;

namespace Training8A.StepDefinitions
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;


        public RegistrationsSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }

        [When(@"Click on register link")]
        public void WhenClickOnRegisterLink()
        {
            registration.ClickOnRegister();
        }

        [When(@"I enter firtname ""(.*)""")]
        public void WhenIEnterFirtname(string firstname)
        {
            registration.EnterFirstName(firstname);
        }

        [When(@"I enter last name ""(.*)""")]
        public void WhenIEnterLastName(string lastname)
        {
            registration.EnterLastName(lastname);
        }


        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }

        [When(@"I enter mobile number ""(.*)""")]
        public void WhenIEnterMobileNumber(string mobileno)
        {
            registration.EnterMobileNo(mobileno);
        }


        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            registration.EnterPassWord(password);
        }


        [When(@"I confirm password ""(.*)""")]
        public void WhenIConfirmPassword(string password)
        {
            registration.EnterPassWord(password);
        }


        [When(@"the click on signUp")]
        public void WhenTheClickOnSignUp()
        {
            registration.ClickSignUP();
        }


        ///[Then(@"I should get a message displayed")]
        //public void ThenIShouldGetAMessageDisplayed()
        //{
        //Assert.IsNull(IsCapthaMsgDisplayed);

        //}

        [Then(@"I should get a message displayed ""(.*)""")]
        public void ThenIShouldGetAMessageDisplayed(string errormessage)
        {
            IWebElement error = Hooks.Driver.FindElement(By.Id("google_cpatcha_error"));
            //Assert.AreNotSame(error, errormessage);
            //Assert.AreNotEqual(errormessage, error);

            Assert.That(registration.GetCapthaMsg, Does.Contain(errormessage));
        }

        [When(@"I enter the floowing details")]
        public void WhenIEnterTheFloowingDetails(Table table)
        {
            RegistrationInput Input = table.CreateInstance<RegistrationInput>();

            registration.EnterFirstName(Input.Firstname);
            registration.EnterLastName(Input.Lastname);
            registration.EnterEmailAddress(Input.Email);
            // registration.EnterMobileNo(Input.Mobileno);
            registration.EnterPassWord(Input.Password);


            // Console.WriteLine(Input.Firstname);
            //Console.WriteLine(Input.Lastname);
            // Console.WriteLine(Input.Mobileno);
            //Console.WriteLine(Input.Email);
            //Console.WriteLine(Input.Password);


        }
    }
}
