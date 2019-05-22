using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using TestSkill.Utilities;

namespace Training8A.PageObjects
{
    
    public class BasePage
    {
        int explicitWaitTime = 20;

        [Obsolete]
        public BasePage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }

        public Boolean WaitForPageLoad()
        {
            Hooks.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(explicitWaitTime);
            return true;
        }

        protected bool IsElementDisplayed(IWebElement element)
        {
            try
            {
                return element.Displayed;
            }
            catch (NoSuchElementException e) {
                return false;
            }

        }

       
        protected Boolean IsElementNotPresent(By selector)
        {
            try
            {
                new WebDriverWait(Hooks.Driver, TimeSpan.FromSeconds(explicitWaitTime))
                .Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(selector)) ;
                return false;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException e)
            {
                return true;
            }
        }
    }
}
