using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestSkill.Utilities
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
            //FirefoxOptions options = new FirefoxOptions();
            //options.AddArgument("headless");
            options.AddArgument("--headless");
            options.AddArgument("--start-maximized");
            options.AddArgument("--kiosk");
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--disable-popup-blocking");
            options.AddArguments("disable-infobars");
            options.AddArgument("--incognito");
            Driver = new ChromeDriver(options);
            //Driver = new FirefoxDriver(options);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
