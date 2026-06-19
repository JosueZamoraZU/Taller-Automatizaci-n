using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Genericos.DriverConfig;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Practica_1.Test
{
    public abstract class BaseTest
    {
        protected IWebDriver Driver;

        protected string reportTestPage = "";
        public static ExtentTest extentTest;
        public static ExtentReports extent;

        public BaseTest(string contectPage)
        {
            this.reportTestPage = contectPage;
        }

        [OneTimeSetUp]

        public void StartReport()
        {

            var spark = new ExtentSparkReporter("Reporte.html");

            extent = new ExtentReports();
            extent.AttachReporter(spark);
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
        }

        [SetUp]

        public void Setup()
        {

            var opcion = new ChromeOptions();
            opcion.AddArguments(" -- start-maximized");

            Driver = ChromeFactory.CrearDriver(opcion);
        }


        [TearDown]

        public void TearDown()
        {

            var status = TestContext.CurrentContext.Result.Outcome.Status;

            if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                extentTest.Pass("Test exitoso");
            }
            else
            {
                extentTest.Fail(
                TestContext.CurrentContext.Result.Message);
            }
            Driver.Dispose();
        }

        [OneTimeTearDown]
        public void EndReport()
        {
            extent.Flush();
        }
    }
}
