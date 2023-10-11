using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecFlowProject1Demo.Pages;
using SpecFlowProject1Demo.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1Demo.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions:CommonDriver
    {
        
        LoginPage logObj = new LoginPage();
        HomePage homeObj = new HomePage();
        TMPage tMPageObj = new TMPage();

        [BeforeScenario]
        public void InitialSteps()
        {
            driver = new ChromeDriver();
            logObj.LoginActons(driver, "hari", "123123");
            homeObj.GoToTMPage(driver);
        }

       /* [Given(@"user logs in to the TurnUp Portal")]
        public void GivenUserLogsInToTheTurnUpPortal()
        {
            driver = new ChromeDriver();

            logObj.LoginActons(driver, "hari", "123123");

        }

        [Given(@"user navigates to Time and Material Page")]
        public void GivenUserNavigatesToTimeAndMaterialPage()
        {
            homeObj.GoToTMPage(driver);

        }*/
        [When(@"user creates a new Time and Material record '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenUserCreatesANewTimeAndMaterialRecord(string code, string description, string price)
        {
            tMPageObj.createTMrecord(driver, code, description, price);
        }

        [Then(@"TurnUp portal should save the new Time and Material record with '([^']*)'")]
        public void ThenTurnUpPortalShouldSaveTheNewTimeAndMaterialRecordWith(string code)
        {
            tMPageObj.AssertCreateTMrecord(driver, code);
            //driver.Close();
        }

        [When(@"user edits an existing Time and Material record '([^']*)' '([^']*)'")]
        public void WhenUserEditsAnExistingTimeAndMaterialRecord(string oldCode, string newCode)
        {
            tMPageObj.editTMRecord(driver, oldCode, newCode);
        }

        [Then(@"TurnUp portal should update Time and Material record '([^']*)'")]
        public void ThenTurnUpPortalShouldUpdateTimeAndMaterialRecord(string newCode)
        {
            tMPageObj.AssertEditTMrecord(driver, newCode);
            //driver.Close();
        }

        [When(@"user deletes an existing Time and Material record '([^']*)'")]
        public void WhenUserDeletesAnExistingTimeAndMaterialRecord(string code)
        {
            tMPageObj.deleteTMRecord(driver, code);
        }

        [Then(@"the record should be deleted '([^']*)'")]
        public void ThenTheRecordShouldBeDeleted(string code)
        {
            tMPageObj.AssertDeleteTMrecord(driver, code);
            //driver.Close();
        }

        [AfterScenario]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
