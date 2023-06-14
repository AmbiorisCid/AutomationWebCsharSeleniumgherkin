using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Automation_Funtional_Testing_Colbun.PageObject
{
    public class Login_SistemaPT : PageBase
    {
        public By txtUsername = By.Id("i0116");
        public By txtPassword = By.Id("i0118");
        protected By BtLoginSiguiente = By.Id("idSIButton9");
        //protected By BtLoginIniciar = By.Id("idSIButton9");
        public By LbError = By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]/h3");

        public By LbBienvenido = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/h1");

        public Login_SistemaPT(IWebDriver driver)
        {
            Driver = driver;
            /*
            if (!driver.Title.Equals("Iniciar sesión en la cuenta"))
                throw new Exception("No es la pagina principal");*/
        }

        public void EnterValortxt(By elemento, String valor)
        {
            cambiarcolor(elemento);
            Driver.FindElement(elemento).SendKeys(valor);
        }
        public void ClickLoginButton()
        {
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(BtLoginSiguiente));
            cambiarcolor(BtLoginSiguiente);
            Driver.FindElement(BtLoginSiguiente).Click();
            
        }
        public Boolean GetlabelText(By elemento, String valor)
        {
            cambiarcolor(elemento);
            //Console.WriteLine(Driver.FindElement(elemento).Text+" = "+valor);
            if (Driver.FindElement(elemento).Text.Trim().Equals(valor.Trim()))
            {
                return true;
            }
            return false;
        }
        public void cambiarcolor(By elemento)
        {
            IWebElement input = Driver.FindElement(elemento);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            // Script que cambia el color de fondo del input a amarillo cuando se hace clic en él
            string scriptClick = @"arguments[0].style.backgroundColor = 'yellow';";
            js.ExecuteScript(scriptClick, input);
        }

    }
}
