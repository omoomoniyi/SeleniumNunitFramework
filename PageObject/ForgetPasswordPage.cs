using OpenQA.Selenium;
using SeleniumNunitFramework.TestUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.PageObject

{
    public class ForgetPasswordPage
    {
        By ForgetPassword = By.XPath("/html/body/div[1]/div[1]/div[2]/div[2]/div[3]/form/div[4]/span");
        By ForgetPasswordEmail = By.CssSelector("div.login-page div.login-page-content div.login-page-content-form div.login-page-content-form-elements form:nth-child(2) div.form__wrapper:nth-child(2) > input.form__input.pointer-initial");
        By ForgetPasswordSubmitButton = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[2]/form[1]/div[2]/button[1]");

        
        public void ClickForgetPassword(string email)

        {

            BrowserActions.Click(ForgetPassword);
            Thread.Sleep(1000);
            BrowserActions.Type(ForgetPasswordEmail, email);
            BrowserActions.Click(ForgetPasswordSubmitButton);
        }

    }
}


