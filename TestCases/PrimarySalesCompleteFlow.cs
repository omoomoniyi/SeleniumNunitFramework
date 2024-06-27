using NUnit.Framework;
using SeleniumNunitFramework.PageObject;
using SeleniumNunitFramework.TestSetup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SeleniumNunitFramework.TestCases
{
    public class PrimarySalesCompleteFlow : BaseSetup
    {
        [Test, TestCaseSource(nameof(GetTestData))]

        public void VerifySwitchingBusinesses(string email, string password)
        {
            PrimarySalesCompleteFlowPO LandingPage = new PrimarySalesCompleteFlowPO();
            LandingPage.Login(email, password);
            Thread.Sleep(10000);


        }



        public static IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(getDataReader().GetTestData("SalesPartnerForPrimarySales"), getDataReader().GetTestData("Password4SalesPartnerForPrimarySales"));

            // yield return new TestCaseData(getDataReader().GetTestData("noEmail"), getDataReader().GetTestData("validPassword"));



        }




    }

}

