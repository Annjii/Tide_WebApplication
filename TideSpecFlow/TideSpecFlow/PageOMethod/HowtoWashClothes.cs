using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TideSpecFlow.Driver;
using TideSpecFlow.Utility;


namespace TideSpecFlow.PageOMethod
{
    public class HowtoWashClothes
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl("https://tide.com/en-us");
            lognet.log.Info("NavigateURL");
        }
        public static void ClickOnButton()
        {
            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            Thread.Sleep(2000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[3]/div/div/div/div[3]/a")).Click();
            lognet.log.Info("ClickOnButton");
        }

        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("HowtoWashClothes");
            lognet.log.Info("TakeSshottest");
        }
    }
}
