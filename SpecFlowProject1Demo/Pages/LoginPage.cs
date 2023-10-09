using OpenQA.Selenium;
using SpecFlowProject1Demo.Utilities;

namespace SpecFlowProject1Demo.Pages
{
    public class LoginPage
    {
        public void LoginActons(IWebDriver driver, string username, string password)
        {
            //navigate to the turnup portal login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //maximize the window
            driver.Manage().Window.Maximize();

            //identify the username field
            Wait.WaitToBeVisible(driver, "Id", "UserName", 5);
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));

            //Enter the username
            userNameTextBox.SendKeys(username);

            //identify the password field
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));

            //Enter the username
            passwordTextBox.SendKeys(password);

            //Identify the login button
            IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Log in']"));

            //click on the login button
            loginButton.Click();
            //driver.SwitchTo().Alert().Accept();

            Thread.Sleep(5000);
        }
    }
}
