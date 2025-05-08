using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace QAWebAutomationTests.Pages
{
    public class InventoryPage
    {
        private readonly IWebDriver driver;

        public InventoryPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public bool IsAt()
        {
            return driver.Url.Contains("inventory.html");
        }

        public IList<IWebElement> GetProductItems()
        {
            return driver.FindElements(By.ClassName("inventory_item"));
        }

        public bool AreProductsVisible()
        {
            var products = driver.FindElements(By.ClassName("inventory_item"));
            return products.Count > 0;
        }

        public void AddFirstProductToCart()
        {
            var addToCartButton = driver.FindElement(By.CssSelector(".inventory_item button"));
            addToCartButton.Click();
        }
    }
}
