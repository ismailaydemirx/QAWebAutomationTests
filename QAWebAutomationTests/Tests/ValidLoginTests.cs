using NUnit.Framework;
using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;

namespace QAWebAutomationTests.Tests
{
    [TestFixture]
    public class ValidLoginTests : TestBase
    {
        public ValidLoginTests()
        {
            shouldLogin = false; // Valid login testi için otomatik login'i devre dışı bırak
        }

        [Test]
        public void ValidLoginTest()
        {
            var test = ExtentManager.CreateTest("Valid Login Test");

            var loginPage = new LoginPage(Driver.Instance);
            loginPage.Login("standard_user", "secret_sauce");

            if (loginPage.IsLoginSuccessful())
            {
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "ValidLoginTest_Pass");
                test.Pass("Giriş başarılı.")
                    .AddScreenCaptureFromPath(screenshotPath);
            }
            else
            {
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "ValidLoginTest_Fail");
                test.Fail("Giriş başarısız.")
                    .AddScreenCaptureFromPath(screenshotPath);
            }

            Assert.IsTrue(loginPage.IsLoginSuccessful());
        }
    }
}
