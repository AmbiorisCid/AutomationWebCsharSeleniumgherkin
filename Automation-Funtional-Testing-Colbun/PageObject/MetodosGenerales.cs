using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Funtional_Testing_Colbun.PageObject
{
    public class MetodosGenerales : PageBase
    {
        public void cambiarColor(By element)
        {
           // WebElement elemnto = Driver.FindElement(By.Id("campP1"));
            //IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           // js.ExecuteScript("\"arguments[0].style.backgroundColor = 'red';\",", element);
        }
    }
}
