using OpenQA.Selenium;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestUtilities
{
    public class BrowserActions :BaseSetup
    {
        public static void Type(By field, string value) 
        {
            WaitUtilities.WaitForElementTOBeDisplayed(field);
            GetDriver().FindElement(field).SendKeys(value);
            
        
        }

        public static void Click(By field) 
        {
            WaitUtilities.WaitForElementTOBeClickable(field);
            GetDriver().FindElement(field).Click();
            //GetDriver().FindElement(field).Click();
        
        }

        public static void MouseEvent(By field)
        {
            GetDriver().FindElement(field).Click();

        }

    }
}
