
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace Automation_Funtional_Testing_Colbun.PageObject
{
    public class CreatPTHome : PageBase
    {
        public By LabelCrear = By.XPath("//*[@id=\"aa8e301c-c79b-4675-8b0c-1de7830162c2\"]/div/div/div/div/nav/ul/li[2]/a");
        public By LabelInstalacion = By.XPath("//*[@id=\"aa8e301c-c79b-4675-8b0c-1de7830162c2\"]/div/div/div/div/nav/ul/li[2]/ul/li[1]");
        public By RadioButtonPersonaInst = By.Id("ChoiceGroupLabel465-1");
        public By RadioButtonEstadoInstl_EID = By.Id("ChoiceGroupLabel467-1");
        public By DronDonwCentral = By.Id("central-option");
        public By ContenedorCentral = By.ClassName("ms-Dropdown-optionText");
        public By DropDonwPt = By.Id("puestrotrabajo-option");
        public By txtInstalacion = By.Id("instalacionintervenir");
        public By dateFechaDesdePlanificacion= By.Id("fechadesde-label");
        public By txtHoraDesde = By.Id("periodohoradesde");
        public By dateFechaHastaPlanificacion = By.Id("fechahasta-label");
        public By txtHoraHasta = By.Id("periodohorahasta");
        public By txtTrabajo = By.Id("trabajorealizar");
        public By txtUbicacion = By.Id("ubicacionfaena");
        public By btSave = By.Id("id__10");
        public By LabelSavePopUp = By.Id("Dialog804-subText"); 
        public By btCerrarPopUp = By.XPath("/html/body/div[2]/div/div/div/div[2]/div[2]/div/div[2]/div/div/div/div/span/button");
        

        public CreatPTHome(IWebDriver driver)
        {
            Driver = driver;
            /*
            if (!driver.Title.Equals("Iniciar sesión en la cuenta"))
                throw new Exception("No es la pagina principal");*/
        }
        public void clickboton(By elemento)
        {

            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 1, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elemento));
            Driver.FindElement(elemento).Click();
        }
        public void FechaInsertCalendar(By elemento,string fecha)
        {
            //Insertar fecha en calendario con campo bloqueados
            Driver.FindElement(elemento).Click();
            IWebElement CalendarioList = Driver.FindElement(By.XPath(string.Format("//*[contains(@class,'ms-DatePicker-day-button')]/span[contains(.,{0})]",fecha)));
            CalendarioList.Click();
        }

        public void DarClickElemntYAgrValor(By elemento, String valor)
        {
            //Da un click primero en el textbox y luego entra el texto
            Driver.FindElement(elemento).Click();
            Driver.FindElement(elemento).SendKeys(valor);
        }    
        public Boolean GetlabelText(By elemento, String valor)
        {
            //toma el valor de un elemento y lo comparar con el valor
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 1, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elemento));
            if (Driver.FindElement(elemento).Text.Trim().Contains(valor.Trim()))
            {
                return true;
            }
            return false;
        }

        public void BuscarText(String texto,By element)
        {
            IList<IWebElement> elemento = Driver.FindElements(element);

            for (int i = 0; i < elemento.Count; i++)
            {
                if (elemento[i].Text.ToString() == texto)
                {
                    elemento[i].Click();
                    break;

                }
            }
        }
    }
}
