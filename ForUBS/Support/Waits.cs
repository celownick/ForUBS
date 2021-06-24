using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ForUBS.Pages
{
    public class Waits
    {

        public static void WaitForElementIsDisplayed(IWebDriver driver, By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch (WebDriverTimeoutException ex)
            {
                throw new WebDriverTimeoutException(
                    $"Element with locator: '{locator}' wasn't visible within specified timeout limit", ex);
            }
        }

        public static void WaitForPageLoad(IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState")
                .Equals("complete"));
        }
        public static bool UntilElementIsNotDisplayed(IWebDriver driver, By elementLocator)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
               return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(elementLocator));
            }
            catch (WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with locator: '{elementLocator}' didn't disappear within specified timeout limit", e);
            }
        }
    }
}