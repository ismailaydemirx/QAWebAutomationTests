using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace QAWebAutomationTests.Utils
{
    public static class ExtentManager
    {
        private static ExtentReports extent;
        private static ExtentTest test;
        private static ExtentSparkReporter sparkReporter;
        private static readonly string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Reports\ExtentReports", "TestReport.html");

        public static void InitReport()
        {
            if (extent == null)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(reportPath));
                
                sparkReporter = new ExtentSparkReporter(reportPath);
                sparkReporter.Config.DocumentTitle = "QA Web Automation Tests Report";
                sparkReporter.Config.ReportName = "QA Automation Test Results";

                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);
            }
        }

        public static ExtentReports GetReporter() => extent;

        public static void FlushReport()
        {
            if (extent != null)
            {
                extent.Flush();
            }
        }

        public static ExtentTest CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
            return test;
        }

        public static ExtentTest GetTest() => test;
    }
}