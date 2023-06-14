using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SigaAutomationFramework.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Automation_Funtional_Testing_Colbun.PageObject
{
    public class HomePage : PageBase 
    {
        // protected By textproduct = By.XPath("//span[@class='title']");
        protected By textproduct = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/h1");
        public By BtnSinGestionar = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/div[1]/div[1]");
        public By BtnEnGestion = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/div[1]/div[2]");
        public By BtnAutorizados = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/div[1]/div[3]");
        public By BtnSolicitudVigencia = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/div[1]/div[4]");
        public By BtnVigenciaSolicitudCancel = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/div[1]/div[5]");

       public By LablCantidad = By.XPath("//*[@id=\"dc2456d3-378b-466b-92e4-aba293a1c397\"]/div/div/div/div/div/div[3]/div/a[2]");
        
        //*[@id="dc2456d3-378b-466b-92e4-aba293a1c397"]/div/div/div/div/div/div[3]/div/a[2]/text()[2]
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }
        public bool TextIspresent()
        {

            return WaitHandler.ElementIsPresent(Driver, textproduct);
        }
        public Boolean GetlabelText(By primeroElemento, By SegundoElemento)
        {
            //Toma los dos elementos y catura puntualmente los valores numericos para compararlos
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 1, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(primeroElemento));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SegundoElemento));
            Thread.Sleep(2000);
            Console.WriteLine(Driver.FindElement(primeroElemento).Text.Substring(0, 3).Trim() + " == "+ Driver.FindElement(SegundoElemento).Text.Substring(3).Trim());
            if (Driver.FindElement(primeroElemento).Text.Substring(0, 3).Trim().Equals(Driver.FindElement(SegundoElemento).Text.Substring(3).Trim()))
            {
                return true;
            }
            return false;
        }


    }
}
