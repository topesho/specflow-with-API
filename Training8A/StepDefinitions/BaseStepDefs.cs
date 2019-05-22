using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSkill.Utilities;

namespace Training8A.StepDefinitions
{
    class BaseStepDefs
    {
        public IWebElement ErrorDescriptionShouldBeDisplayed(String Id)
        {
            By id = By.Id("id");
            IWebElement errorMessage = Hooks.Driver.FindElement(id);
            Assert.That(errorMessage.ToString().Contains(Id));
            return errorMessage;
        }

        
    }
}
