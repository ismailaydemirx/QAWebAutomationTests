using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;
using NUnit.Framework;

namespace QAWebAutomationTests.Tests
{
    [TestFixture]
    public class CartTests : TestBase
    {
        [Test]
        public void ProductsAreVisibleInCart()
        {
            var test = ExtentManager.CreateTest("Products Are Visible In Cart");
            try
            {
                // Önce bir ürün ekleyelim
                var inventoryPage = new InventoryPage(Driver.Instance);
                inventoryPage.AddFirstProductToCart();
                
                // Cart sayfasına gidelim ve kontrolleri yapalım
                var cartPage = new CartPage(Driver.Instance);
                cartPage.NavigateToCart();
                
                Assert.IsTrue(cartPage.IsAt(), "Sepet sayfası görüntülenemiyor.");
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "CartPage_Navigation");
                test.Pass("Sepet sayfası başarıyla görüntülendi.")
                    .AddScreenCaptureFromPath(screenshotPath);

                Assert.IsTrue(cartPage.AreProductsVisible(), "Sepetteki ürünler görünmüyor.");
                test.Pass("Sepetteki ürünler görünür durumda.");
            }
            catch (AssertionException e)
            {
                string screenshotPath = ScreenshotHelper.CaptureScreenshot(Driver.Instance, "CartProductsVisibility_Fail");
                test.Fail("Assertion hatası: " + e.Message)
                    .AddScreenCaptureFromPath(screenshotPath);
                throw;
            }
        }
    }
} 