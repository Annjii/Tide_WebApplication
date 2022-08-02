using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TideSpecFlow.Utility;

namespace TideSpecFlow.Driver
{  
    public class method
    {
        public static IWebDriver driver;
        public static void InitializeDriver()
        {
            driver = new ChromeDriver();

            lognet.log.Info("InitializeDriver");
            
        }
        public static void CloseDriver()
        {
            
            driver.Close();
            lognet.log.Info("CloseDriver");
        }
        
    }
}
