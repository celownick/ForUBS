namespace ForUBS.Pages.PrivacySettingsPage
{
    using OpenQA.Selenium;
    public class PrivacySettingsPageElements
    {
        public By AcceptAllButton => By.XPath("//fieldset[@class='privacysettings__fieldset']/button[@data-ps-tracking-button-version='acceptAll']");

        public By CookieText => By.XPath("//span[@class='privacysettings--singleStepElement']/p");
        
        public By PopUp => By.ClassName("form__action");
    }
}