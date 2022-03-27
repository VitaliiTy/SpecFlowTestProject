using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTestProject.Drivers
{
    public class Driver
    {
        public static IWebDriver driver;
        public static IWebDriver GetWebDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}
