using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TestSkill.Utilities;

namespace Training8A.PageObjects
{
    public class BasePage
    {
     
        public BasePage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        public Boolean WaitForPageLoad()
        {
            Hooks.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            return true;
        }

        protected bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch ( NoSuchElementException e) {
                return false;
            }
            }
        }   
}
