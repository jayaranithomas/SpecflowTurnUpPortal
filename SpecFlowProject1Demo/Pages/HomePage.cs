using NUnit.Framework;
using OpenQA.Selenium;

namespace SpecFlowProject1Demo.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try
            {
                //Click on the Administration dropdown
                IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationDropdown.Click();
            }

            catch (Exception ex)
            {
                Assert.Fail("Home page not displayed", ex.Message);
            }
            //select the Time and Material option
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
