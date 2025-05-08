using NUnit.Framework;
using QAWebAutomationTests.Utils;
using QAWebAutomationTests.Pages;

namespace QAWebAutomationTests.Tests
{
    public class TestBase
    {
        protected bool shouldLogin = true; // Login gerekli olmayan testler için override edilecek.

        [OneTimeSetUp]
        public void InitializeReport()
        {
            if (ExtentManager.GetReporter() == null)
            {
                ExtentManager.InitReport();
            }
        }

        [SetUp]
        public virtual void Setup()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl("https://www.saucedemo.com/");
            
            if (shouldLogin)
            {
                var loginPage = new LoginPage(Driver.Instance);
                loginPage.Login("standard_user", "secret_sauce");
            }
        }

        [TearDown]
        public virtual void TearDown()
        {
            Driver.Quit();
        }

        [OneTimeTearDown]
        public void FinalizeReport()
        {
            ExtentManager.FlushReport();
        }
    }
} 