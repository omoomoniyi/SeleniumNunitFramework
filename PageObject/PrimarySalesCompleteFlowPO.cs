using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitFramework.PageObject
{
    public class PrimarySalesCompleteFlowPO
    {
        By Email = By.XPath("//body/div[@id='app-root']/div[1]/div[2]/div[2]/div[3]/form[1]/div[1]/input[1]");
        By Password = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[2]/input[1]");
        By LoginButton = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[3]/form[1]/div[3]/button[1]");
        By SwitchBusinessesDropDown = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[2]/div[1]/img[1]");
        By SecondDropDownToSelectBusiness = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/select[1]");
        By SwitchToPowerOilSales = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[4]/div[1]/ul[1]/li[4]");
        By SuccessfulBusinessSwitchModal = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[1]/button[1]");
        By ContactManagement = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[2]/a[1]/div[1]/span[1]");
        By Contact = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/ul[1]/li[2]/div[1]/a[1]");
        By HamburgerIconOnDistributorContactCard = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[3]/div[8]");
        By StartMeetingFromHamburgerIconOnDistributorContactCard = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[3]/div[1]/div[1]/div[2]/div[4]/div[1]/div[1]");
        By NewOrder = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[4]/div[2]/div[1]/div[1]/div[1]/button[1]");
        By ProductSKUPow001 = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div[3]");
        By ProductSKUPow001QTY = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[2]/div[2]/div[1]/div[2]/form[1]/div[1]/div[1]/input[1]");



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
            BrowserActions.Click(SecondDropDownToSelectBusiness);
            Thread.Sleep(5000);
            BrowserActions.Click(SwitchToPowerOilSales);
            BrowserActions.Click(SuccessfulBusinessSwitchModal);
            BrowserActions.Click(ContactManagement);
            BrowserActions.Click(Contact);
            BrowserActions.Click(HamburgerIconOnDistributorContactCard);
            BrowserActions.Click(StartMeetingFromHamburgerIconOnDistributorContactCard);
            Thread.Sleep(5000);
            BrowserActions.Click(NewOrder);
            Thread.Sleep(5000);
            






        }

    }
}
