using Automation_Funtional_Testing_Colbun.Hooks;
using Automation_Funtional_Testing_Colbun.PageObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation_Funtional_Testing_Colbun.Steps
{
    [Binding]
    class RedireccionesPTSteps_SistemaPT : BaseTest
    {
        CreatPTHome creatPTHome = new CreatPTHome(Driver);
        HomePage home = new HomePage(Driver);

        [When(@"click in Sin gestionar")]
        public void ClickInSinGestionar()
        {
           creatPTHome.clickboton(home.BtnSinGestionar);
           Assert.IsTrue(home.GetlabelText(home.BtnSinGestionar,home.LablCantidad));
        }

        [When(@"click in En gestion")]
        public void clickInEnGestion()
        {
            creatPTHome.clickboton(home.BtnEnGestion);
            Assert.IsTrue(home.GetlabelText(home.BtnEnGestion, home.LablCantidad));
           
        }
        [When(@"click in Autorizados")]
        public void clickInAutorizados()
        {
            creatPTHome.clickboton(home.BtnAutorizados);
            Assert.IsTrue(home.GetlabelText(home.BtnAutorizados, home.LablCantidad));
        }
        [When(@"click in Solicitud de vigencia")]
        public void clickInSolicitudDeVigencia()
        {
            creatPTHome.clickboton(home.BtnSolicitudVigencia);
            Assert.IsTrue(home.GetlabelText(home.BtnSolicitudVigencia, home.LablCantidad));
        }
        [When(@"click in Vigencia solicitud cancelacion")]
        public void clickInVigenciaSolicitudCancelacion()
        {
            creatPTHome.clickboton(home.BtnVigenciaSolicitudCancel);
            Assert.IsTrue(home.GetlabelText(home.BtnVigenciaSolicitudCancel, home.LablCantidad));
        }


    }
}
