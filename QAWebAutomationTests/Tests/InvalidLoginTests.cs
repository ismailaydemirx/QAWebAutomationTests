using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAWebAutomationTests.Tests
{
    public class InvalidLoginTests
    {
        [Test]
        public void InvalidLoginTest()
        {
            var loginPage = new LoginPage(Driver.Instance);
            loginPage.Login("invalid_user", "wrong_password");

            // Hata mesajı görünüyor mu kontrol edelim
            var errorMessage = loginPage.GetErrorMessage();
            Assert.IsTrue(errorMessage.Contains("Epic sadface"), "Hata mesajı bekleniyordu ama görünmedi.");
        }

    }
}
