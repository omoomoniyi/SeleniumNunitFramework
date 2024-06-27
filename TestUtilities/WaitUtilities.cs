using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumNunitFramework.TestUtilities
{
    public class WaitUtilities: BaseSetup
    {

        public static void WaitForElementTOBeDisplayed(By element)
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));

        }

        public static void WaitForElementTOBeClickable(By element)
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public static void WaitForElementTOBePresent(By element)
        {
            WebDriverWait wait = new WebDriverWait(GetDriver(), TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(element));
        }
    }
}
