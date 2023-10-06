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
        [Given(@"user logs in to the TurnUp Portal")]
        public void GivenUserLogsInToTheTurnUpPortal()
        {
            driver = new ChromeDriver();

          logObj.LoginActons(driver, "hari", "123123");
                             
        }

        [Given(@"user navigates to Time and Material Page")]
        public void GivenUserNavigatesToTimeAndMaterialPage()
        {
            homeObj.GoToTMPage(driver);
            
        }

        [When(@"user creates a new Time and Material record")]
        public void WhenUserCreatesANewTimeAndMaterialRecord()
        {
            tMPageObj.createTMrecord(driver, "code", "description", "300.50");
        }

        [Then(@"TurnUp portal should save the new Time and Material record")]
        public void ThenTurnUpPortalShouldSaveTheNewTimeAndMaterialRecord()
        {
            tMPageObj.AssertCreateTMrecord(driver, "code");
            driver.Close();
        }
        [When(@"user edits an existing Time and Material record")]
        public void WhenUserEditsAnExistingTimeAndMaterialRecord()
        {
            tMPageObj.editTMRecord(driver, "edit code", "edit desc", "100.00");
        }

        [Then(@"TurnUp portal should save the edited Time and Material record")]
        public void ThenTurnUpPortalShouldSaveTheEditedTimeAndMaterialRecord()
        {
            tMPageObj.AssertEditTMrecord(driver, "edit code");
            driver.Close();
        }
        [When(@"user deletes an existing Time and Material record")]
        public void WhenUserDeletesAnExistingTimeAndMaterialRecord()
        {
            tMPageObj.deleteTMRecord(driver);
        }

        [Then(@"TurnUp portal should update Time and Material portal")]
        public void ThenTurnUpPortalShouldUpdateTimeAndMaterialPortal()
        {
            tMPageObj.AssertDeleteTMrecord(driver, "edit code");
            driver.Close();
        }


    }
}
