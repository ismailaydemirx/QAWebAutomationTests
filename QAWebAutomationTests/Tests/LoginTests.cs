using NUnit.Framework;
using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;

namespace QAWebAutomationTests.Tests
{

    [TestFixture]
    public class LoginTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void ValidLoginTest()
        {
            var loginPage = new LoginPage(Driver.Instance);
            loginPage.Login("standard_user", "secret_sauce");
            Assert.IsTrue(Driver.Instance.Url.Contains("inventory"));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }

}
