using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Automation_Funtional_Testing_Colbun;
using TechTalk.SpecFlow.Events;

namespace Automation_Funtional_Testing_Colbun.Hooks
{
    [Binding]
    class BaseTest
     {
        
        protected static IWebDriver Driver;
       protected static ExtentTest scenario;


        [BeforeScenario]
        public static void BeforeBaseTest()
        {
            ChromeOptions options= new ChromeOptions();
            //options.AddArgument("headless");
            options.AddArgument("no-sandbox");
            Driver= new ChromeDriver(options);            
        }
        [AfterScenario]
        public static void AfterBaseTest() 
        {   
            if (Driver != null)
            {
                Driver.Quit();
            }
        }


    }
}
