using OpenQA.Selenium;

namespace QAWebAutomationTests.Pages
{
    public class CartPage
    {
        private readonly IWebDriver driver;

        public CartPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }

        public bool IsAt()
        {
            return driver.Url.Contains("cart.html");
        }

        public bool AreProductsVisible()
        {
            var cartItems = driver.FindElements(By.ClassName("cart_item"));
            return cartItems.Count > 0;
        }

        public void NavigateToCart()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
        }
    }
} 