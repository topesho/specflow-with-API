using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestSkill.PageObjects;
using TestSkill.Utilities;
using TechTalk.SpecFlow.Assist;

namespace TestSkill.StepDefinitions
{
    [Binding]
    public class RegistrationsStepsDef
    {
        RegistrationPage registration;


        public RegistrationsStepsDef()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
            registration.WaitForPageLoad();
         
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

        //[when(@"i provide answer for all the fields on the page and click continue (.*) time")]
        //public void wheniprovideanswerforallthefieldsonthepageandclickcontinuetime(int numberoftimes)
        //{

        //    int i = 0;
        //    while (i < numberoftimes)
        //    {
        //        this.registration.findallformfieldandentervalue("0");
        //        this.applicationformpage.clicksaveandcontinue();
        //        this.applicationformpage.waitforpagetobeloaded();
        //        i++;
        //    }



        //}

        [When(@"I can see the mobileno textbox")]
        public void WhenICanSeeTheMobilenoTextbox()
        {
            Assert.That(registration.IsMobileTextBoxDisplayed(), Is.True);

        }

    }
}
