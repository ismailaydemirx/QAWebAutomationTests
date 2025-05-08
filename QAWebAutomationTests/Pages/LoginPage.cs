using OpenQA.Selenium;

namespace QAWebAutomationTests.Pages
{

    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        private IWebElement UsernameField => driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordField => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }

}
