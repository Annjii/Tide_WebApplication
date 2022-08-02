using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TideSpecFlow.Utility;
using TideSpecFlow.Driver;

namespace TideSpecFlow.Hooks
{
    [Binding]
    public class HooksFiles
    {
        [BeforeTestRun]
        public static void GenerateReport()
        {
            ExtentR.generateReport();
            
        }
        [AfterTestRun]
        public static void closeExtentReport()
        {
            ExtentR.flushReport();

        }
        [BeforeFeature]
        public static void featureBrowser(FeatureContext featureContext)
        {
            ExtentR.featurefile();
            lognet.log.Info("FeatureWebsites");
        }

        [BeforeScenario]
        public static void InitializeDriver(ScenarioContext scenarioContext)
        {

            method.InitializeDriver();
            ExtentR.scenarioflie();
            lognet.log.Info("FeatureWebsites");
        }

        [AfterStep]
        public static void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            ExtentR.scenariosteps();
        }

        [AfterScenario]
        public static void CloseDriver()
        {
            method.driver.Close();
        }
    }
}

