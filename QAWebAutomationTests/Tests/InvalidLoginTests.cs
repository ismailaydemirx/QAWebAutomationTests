using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;
using NUnit.Framework;

namespace QAWebAutomationTests.Tests
{
    [TestFixture]
    public class InvalidLoginTests : TestBase
    {
        public InvalidLoginTests()
        {
            shouldLogin = false; // Invalid login testi için otomatik login'i devre dışı bırak
        }

        [Test]
        public void InvalidLoginTest()
        {
            var test = ExtentManager.CreateTest("InvalidLoginTest");

            var loginPage = new LoginPage(Driver.Instance);
            loginPage.Login("invalid_user", "wrong_password");

            var errorMessage = loginPage.GetErrorMessage();

            if(errorMessage.Contains("Epic sadface"))
            {
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "InvalidLoginTest_Pass");
                test.Pass("Hata mesajı başarıyla görüntülendi.")
                    .AddScreenCaptureFromPath(screenshotPath);
            }
            else
            {
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "InvalidLoginTest");
               
                test.Fail("Hata mesajı bekleniyordu ama görünmedi")
                    .AddScreenCaptureFromPath(screenshotPath);
            }

            Assert.IsTrue(errorMessage.Contains("Epic sadface"));
        }
    }
}
