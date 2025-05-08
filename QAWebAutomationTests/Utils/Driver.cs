using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAWebAutomationTests.Utils
{
    public static class Driver
    {
        public static IWebDriver Instance { get; private set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
        }

        public static void Quit()
        {
            Instance.Quit();
        }
    }

}
