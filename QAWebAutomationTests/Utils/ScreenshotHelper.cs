using OpenQA.Selenium;
using System;
using System.IO;

namespace QAWebAutomationTests.Utils
{
    public class ScreenshotHelper
    {
        public static string CaptureScreenshot (IWebDriver driver, string screenshotName)
        {
            var screenshotsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Reports\ExtentReports\Screenshots");
            Directory.CreateDirectory(screenshotsDir);

            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var filePath = Path.Combine(screenshotsDir, $"{screenshotName}_{timestamp}.png");

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(filePath);

            return filePath;
        }
    }
}
