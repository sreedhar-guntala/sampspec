using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowTest.Library
{
    public class Lib
    {
        public static IWebDriver Driver;
        String Driverpath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Drivers"));
        Actions.Actions actions = new Actions.Actions();
        

        public IWebDriver GetDriver(string Browser)
        {
            switch (Browser)
            {
                case "chrome":
                case "Chrome":
                    Driver = new ChromeDriver(Driverpath);
                    break;

                case "firefox":
                case "Firefox":
                    Driver = new FirefoxDriver();
                    break;

                case "ie":
                case "IE":
                    Driver = new InternetExplorerDriver(Driverpath);
                    break;
            }
            Driver.Manage().Window.Maximize();
            return Driver;
        }
    }
}
