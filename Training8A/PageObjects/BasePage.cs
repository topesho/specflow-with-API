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

        public void WaitForPageLoad()
        {
            Hooks.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }
    }
}
