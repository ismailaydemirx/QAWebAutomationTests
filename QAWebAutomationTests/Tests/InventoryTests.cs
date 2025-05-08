using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;
using NUnit.Framework;

namespace QAWebAutomationTests.Tests
{
    [TestFixture]
    public class InventoryTests : TestBase
    {
        [Test]
        public void ProductsAreVisibleAfterLogin()
        {
            var test = ExtentManager.CreateTest("Products Are Visible After Login");
            try
            {
                var inventoryPage = new InventoryPage(Driver.Instance);

                Assert.IsTrue(inventoryPage.IsAt(), "Kullanıcı inventory sayfasında değil.");
                test.Pass("Kullanıcı inventory sayfasında.");

                Assert.IsTrue(inventoryPage.AreProductsVisible(), "Ürünler görünmüyor.");
                string screenshotPath2 = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "Products_Visibility");
                test.Pass("Ürünler görünür durumda.")
                    .AddScreenCaptureFromPath(screenshotPath2);
            }
            catch (AssertionException e)
            {
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "ProductsVisibility_Fail");
                test.Fail("Assertion hatası: " + e.Message)
                    .AddScreenCaptureFromPath(screenshotPath);
                throw;
            }
        }
    }
}
