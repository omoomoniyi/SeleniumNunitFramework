using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitFramework.PageObject
{
    public class BusinessSwitchPO
    {
        By Email = By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]");
        By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginButton = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By SwitchBusinessesDropDown = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/img[1]");
        By SwitchToIndomieNoodlesSales = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/select[1]/option[35]");  
                                                   





        public void Login(string email, string pass)

        {
            BrowserActions.Type(Email, email);
            //driver.FindElement(Password).SendKeys("123456789");
            BrowserActions.Type(Password, pass);
            //driver.FindElement(LoginButton).Click();
            //BrowserActions.Click(EyeIcon);
            BrowserActions.Click(LoginButton);
            Thread.Sleep(60000);
            BrowserActions.Click(SwitchBusinessesDropDown);
            Thread.Sleep(1000);
            BrowserActions.Click(SwitchToIndomieNoodlesSales);
            //String expected_title = "You have successfully switched to Indomie Noodles Sales";
            //String actual_title = "You have successfully switched to Indomie Noodles Sales1";


        }

    }
}
