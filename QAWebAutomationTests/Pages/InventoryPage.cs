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
            return driver.Url.Contains("inventory");
        }

        public IList<IWebElement> GetProductItems()
        {
            return driver.FindElements(By.ClassName("inventory_item"));
        }

        public bool AreProductsVisible()
        {
            return GetProductItems().Any();
        }
    }
}
