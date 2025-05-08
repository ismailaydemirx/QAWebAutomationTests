using QAWebAutomationTests.Pages;
using QAWebAutomationTests.Utils;

namespace QAWebAutomationTests.Tests
{
    [TestFixture]
    public class InventoryTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Driver.Instance.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void ProductsAreVisibleAfterLogin()
        {
            var loginPage = new LoginPage(Driver.Instance);
            loginPage.Login("standard_user", "secret_sauce"); 

            var inventoryPage = new InventoryPage(Driver.Instance);

            Assert.IsTrue(inventoryPage.IsAt(), "Kullanıcı inventory sayfasında değil.");
            Assert.IsTrue(inventoryPage.AreProductsVisible(), "Ürünler görünmüyor.");
        }
    }
}
