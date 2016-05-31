using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowTest.Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowTest.Fixures
{
    [Binding]
    public class Fixtures
    {
        public static IWebDriver Driver;
        [BeforeFeature]
        public static void BeforeFeature()
        {
            string BrowserName = ConfigurationManager.AppSettings["BrowserName"];
            Lib Library = new Lib();
            Library.GetDriver(BrowserName);

        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Library.Lib.Driver.Quit();
        }
    }
}
