using Automation_Funtional_Testing_Colbun.Hooks;
using Automation_Funtional_Testing_Colbun.PageObject;
using Humanizer.Localisation;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace Automation_Funtional_Testing_Colbun.Steps
{
    [Binding]
     class LoginSteps_SistemaPT : BaseTest
    {
         //Login_SistemaPT login = new Login_SistemaPT(Driver);
        
        [Given(@"the user navigate the web page (.*)")]
        public void GivenTheUserNavigateTheWebPage(string p)
        {
            Driver.Navigate().GoToUrl(p);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
        }
        
        [When(@"the user enter usuario (.*)")]
        public void WhenTheUserEnterUsuario(string valor)
        {
            Login_SistemaPT loginPage = new Login_SistemaPT(Driver);
            loginPage.EnterValortxt(loginPage.txtUsername,valor);
            
        }
        [When(@"the user click button")]
        public void WhenTheUserClickButton()
        {
            Login_SistemaPT loginPage = new Login_SistemaPT(Driver);
            loginPage.ClickLoginButton();
            Thread.Sleep(5000);

        }
        [When(@"digit password (.*)")]
        public void WhenDigitPassword(string valor)
        {
            Login_SistemaPT loginPage = new Login_SistemaPT(Driver);
            loginPage.EnterValortxt(loginPage.txtPassword, valor);
           
        }
        [When(@"the user again click button")]
        public void WhenTheUserAgainClickButton()
        {
            Login_SistemaPT loginPage = new Login_SistemaPT(Driver);
            loginPage.ClickLoginButton();
            Thread.Sleep(5000);

        }

        [When(@"keep me signed in")]
        public void WhenKeepMeSignedIn()
        {
            Login_SistemaPT loginPage = new Login_SistemaPT(Driver);
            loginPage.ClickLoginButton();
            //Thread.Sleep(5000);

        }


        [Then(@"the user should see that he logged in corretly")]
        public void ThenTheUserShouldSeeThatHeLoggedInCorretly()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.TextIspresent();


        }
        /*
        [Then(@"the user gets an error message(.*)")]
        public void ThenTheUserGetsAnError(string mensaje)
        {
            Login_SistemaPT loginPage = new Login_SistemaPT(Driver);
            Assert.IsTrue(loginPage.GetlabelText(loginPage.LbError, mensaje));
        }
        */
    }
}
