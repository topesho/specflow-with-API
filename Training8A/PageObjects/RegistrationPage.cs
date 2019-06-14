using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSkill.Utilities;
using Training8A.PageObjects;

namespace TestSkill.PageObjects
{
    class RegistrationPage : BasePage
    {
        //private int explicitWaitTime = 20;


        [Obsolete]
        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first_name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        private IWebElement lastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        [FindsBy(How = How.ClassName, Using = "le-input")]
        public IWebElement MobileNo { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement PassWord { get; set; }

        [FindsBy(How = How.Id, Using = "google_cpatcha_error")]
        public IWebElement CaptchaMsg { get; set; }
       
        public void ClickSignUP()
        {

            signUp.Click();
        }


        public void ClickOnRegister()
        {
            register.Click();
        }

        public void EnterFirstName(string firstname)
        {
            firstName.SendKeys(firstname);
        }


        public void EnterLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }

        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);
        }

        public void EnterMobileNo(string mobileno)
        {
            MobileNo.SendKeys(mobileno);
        }

        public void EnterPassWord(string password)
        {
            PassWord.SendKeys(password);
        }

        public Boolean IsCapthaMsgDisplayed()
        {
            return CaptchaMsg.Displayed;

        }

        public String GetCapthaMsg()
        {
            return CaptchaMsg.Text;

        }
        
        public Boolean IsMobileTextBoxDisplayed()
        {
            return IsElementDisplayed(MobileNo);
        }

        public Boolean IsLoggingMessageNotPresent()
        {
            return IsElementNotPresent(By.Id("vvvv"));
        }
    }
}
