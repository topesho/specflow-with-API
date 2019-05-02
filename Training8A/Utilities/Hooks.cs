using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Training8A.Utilities
{
    [Binding]
    public class Hooks
    {
        public static IWebDriver Driver;
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            Driver = new ChromeDriver(options);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
