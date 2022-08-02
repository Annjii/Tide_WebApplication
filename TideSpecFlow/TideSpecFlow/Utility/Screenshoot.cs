using OpenQA.Selenium;
using TideSpecFlow.Driver;
using TideSpecFlow.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TideSpecFlow.Utility
{
    public class Screenshoot
    {
        public static void TakeSshoot(String SShottest)
        {
            ((ITakesScreenshot)method.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may266\Desktop\M1089290 Comprehensive\Automation\TideSpecFlow\TideSpecFlow\Screenshoot\" + SShottest + ".Png");
        }
    }
}

