using System;
using ForUBS.Configuration;
using ForUBS.Pages;
using ForUBS.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ForUBS.Drivers
{
    public class DriverFactory
    {
        public static IWebDriver Driver { get; set; }

        public ISearchContext SearchContext => Driver;

        public IWebDriver CreateDriver()
        {
            BrowserType browser = TestConfigurationSection.SectionDetails.Browser;
            IWebDriver driver = null;
            switch (browser)
            {
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.InternetExplorer:
                    driver = new InternetExplorerDriver();
                    break;
            }

            return ConfigureDriver(driver);
        }

        private IWebDriver ConfigureDriver(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            var timeout = TestConfigurationSection.SectionDetails.WaitTimeout;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(timeout);

            return Driver = driver;
        }

        public IWebDriver GetDriver()
        {
            if (Driver != null)
            {
                return Driver;
            }

            CreateDriver();
            return Driver;
        }
    }
}