using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using TechTalk.SpecFlow;

namespace TideSpecFlow.Utility
{
    public class ExtentR
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        private static ExtentTest feature;
        private static ExtentTest scenario;


        public static void generateReport()
        {
            var htmlRepoter = new ExtentHtmlReporter(@"C:\Users\mindc1may266\Desktop\M1089290 Comprehensive\Automation\TideSpecFlow\TideSpecFlow\Index.html");
            htmlRepoter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlRepoter);
            lognet.log.Info("generateReport");

        }
        public static void featurefile()
        {
            feature = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }
        public static void scenarioflie()
        {
            scenario = feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }
        public static void scenariosteps()
        {

            if (ScenarioContext.Current.TestError == null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            if (ScenarioContext.Current.TestError != null)
            {
                var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }
        }
        public static void flushReport()
        {
            extent.Flush();
            lognet.log.Info("flushReport");
        }
    }
}
