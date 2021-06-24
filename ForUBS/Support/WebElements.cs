using System;
using ForUBS.Drivers;
using OpenQA.Selenium;

namespace ForUBS.Pages
{
    public class WebElements
    {
        private readonly IWebDriver driver;

        public WebElements(DriverFactory driverFactory)
        {
            this.driver = driverFactory.GetDriver();
        }

        public void ClickDisplayedElement(By locator)
        {
            Waits.WaitForPageLoad(driver);
            Waits.WaitForElementIsDisplayed(driver, locator);
            driver.FindElement(locator).Click();
        }

        public void ScrollAndClick(By locator)
        {
            Waits.WaitForPageLoad(driver);
            ScrollToElement(locator);
            Waits.WaitForElementIsDisplayed(driver, locator);
            driver.FindElement(locator).Click();
        }

        public void SendKeys(By locator, String keys)
        {
            Waits.WaitForPageLoad(driver);
            Waits.WaitForElementIsDisplayed(driver, locator);
            driver.FindElement(locator).SendKeys(keys);
        }

       public string GetDisplayedTextOfElement(By locator)
        {
            Waits.WaitForElementIsDisplayed(driver, locator);
            var text = driver.FindElement(locator).Text;
            return text;
        }

        public void ScrollToElement(By locator)
        {
            IWebElement elem = driver.FindElement(locator);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);",
                elem);
        }

        public IWebElement GetElement(By elementLocator)
        {
            Waits.WaitForElementIsDisplayed(driver, elementLocator);
            return driver.FindElement(elementLocator);
        }


        public bool IsNotDisplayed(By elementLocator)
        {
            return Waits.UntilElementIsNotDisplayed(DriverFactory.Driver, elementLocator);
        }

        public void SwitchToIframe(By elementLocator)
        {
            IWebElement elem = GetElement(elementLocator);
            driver.SwitchTo().Frame(elem);
        }

        public void SwitchFromIframe()
        {
            driver.SwitchTo().DefaultContent();
        }
    }
}