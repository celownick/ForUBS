
namespace ForUBS.Pages.PrivacySettingsPage
{
    public class PrivacySettingsPageActions : BaseActions
    {
        private readonly PrivacySettingsPageElements PrivacySettingsPageElements;

        public PrivacySettingsPageActions(WebElements webElements,
            PrivacySettingsPageElements privacySettingsPageElements) : base(webElements)
        {
            this.PrivacySettingsPageElements = privacySettingsPageElements;
        }

        public void ClickAcceptAllButton()
        {
            this.WebElements.ClickDisplayedElement(PrivacySettingsPageElements.AcceptAllButton);
        }

        public void GetDisplayedTextOfElement()
        {
            this.WebElements.GetDisplayedTextOfElement(PrivacySettingsPageElements.CookieText);
        }

        public bool IsPrivacySettingsPopUpNotDisplayed()
        {
            return this.WebElements.IsNotDisplayed(this.PrivacySettingsPageElements.PopUp);
        }

        public bool IsPrivacySettingsPopUpDisplayed()
        {
            return this.WebElements.GetElement(this.PrivacySettingsPageElements.PopUp).Displayed;
        }
    }
}