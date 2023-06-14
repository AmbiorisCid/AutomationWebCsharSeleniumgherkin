
using TechTalk.SpecFlow;
using Automation_Funtional_Testing_Colbun.Hooks;
using Automation_Funtional_Testing_Colbun.PageObject;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace Automation_Funtional_Testing_Colbun.Steps
{
    [Binding]
     class CrearPTSteps_SistemaPT : BaseTest
    {
        CreatPTHome creatPTHome = new CreatPTHome(Driver);

        [When(@"user click in CrearPt")]
         public void UserClickInCrearPt()
        {
            creatPTHome.clickboton(creatPTHome.LabelCrear);
        }
       
        [When(@"too click PT instalacion")]
        public void TooClickPTInstalacion()
        {
            creatPTHome.clickboton(creatPTHome.LabelInstalacion);
        }
        [When(@"click in tipo personal")]
        public void ClickInTipoPersonal()
        {
            creatPTHome.clickboton(creatPTHome.RadioButtonPersonaInst);
        }

        [When(@"select State Instal")]
        public void SelectStateInstal()
        {
            creatPTHome.clickboton(creatPTHome.RadioButtonEstadoInstl_EID);
            
        }
        [When(@"press dropDonw central")]
        public void PressDropDonwCentral()
        {
            creatPTHome.clickboton(creatPTHome.DronDonwCentral);
            
        }
        [When(@"Digit the consult (.*)")]
        public void DigitTheConsult( String Consult)
        {
            //Console.WriteLine("Äqui llego " + Consult);
            creatPTHome.BuscarText(Consult,creatPTHome.ContenedorCentral);
        }
        [When(@"select DropDonw PT")]
        public void selectDropDonwPT()
        {
            //Console.WriteLine("Äqui llego " + Consult);
            creatPTHome.clickboton(creatPTHome.DropDonwPt);
            //Thread.Sleep(5000);
        }

        [When(@"Consult DropDonw PT (.*)")]
        public void ConsultDropDonwPT(String Consult)
        {
            creatPTHome.BuscarText(Consult, creatPTHome.ContenedorCentral);
        }
        [When(@"Insert text in instalation (.*)")]
        public void InsertTextInInstalacion(String Consult)
        {
            Login_SistemaPT login = new Login_SistemaPT(Driver);
            login.EnterValortxt(creatPTHome.txtInstalacion,Consult);
            
        }
        [When(@"Digit datetime Owner (.*)")]
        public void DigitDatetimeOwner(String Consult)
        {
            creatPTHome.FechaInsertCalendar(creatPTHome.dateFechaDesdePlanificacion, Consult);
                Thread.Sleep(5000);
        }
        [When(@"set the time from (.*)")]
        public void SetTheTimeDesde(String Consult)
        {
            creatPTHome.DarClickElemntYAgrValor(creatPTHome.txtHoraDesde,Consult);
        }

        [When(@"Digit until datetime (.*)")]
        public void DigitUntilDatetime(String Consult)
        {
            creatPTHome.FechaInsertCalendar(creatPTHome.dateFechaHastaPlanificacion, Consult);
            Thread.Sleep(5000);
        }
        [When(@"set the timeHasta (.*)")]
        public void SetTheTimeHasta(String Consult)
        {
            creatPTHome.DarClickElemntYAgrValor(creatPTHome.txtHoraHasta, Consult);
            Thread.Sleep(5000);
        }

        [When(@"Digit text wordkDo (.*)")]
        public void DigitTextWorkDo(String Consult)
        {
            Login_SistemaPT login = new Login_SistemaPT(Driver);
            login.EnterValortxt(creatPTHome.txtTrabajo, Consult);

        }

        [When(@"Insert location for (.*)")]
        public void InsertLocationFor(String Consult)
        {
            Login_SistemaPT login = new Login_SistemaPT(Driver);
            login.EnterValortxt(creatPTHome.txtUbicacion, Consult);
        }

        [When(@"Press button save")]
        public void PressButtonSave()
        {
            creatPTHome.clickboton(creatPTHome.btSave);

        }
        [Then(@"User validet the saved (.*)")]
        public void UserValidetTheSaved(String mensaje)
        {
            //Console.WriteLine(Driver.FindElement(creatPTHome.LabelSavePopUp).Text + " = " + mensaje);
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 1, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(creatPTHome.btCerrarPopUp));
            Assert.IsTrue(creatPTHome.GetlabelText(creatPTHome.LabelSavePopUp, mensaje));
            creatPTHome.clickboton(creatPTHome.btCerrarPopUp);
        }

    }
}
