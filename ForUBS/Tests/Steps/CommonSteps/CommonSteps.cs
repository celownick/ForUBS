using ForUBS.Enums;
using ForUBS.Pages;
using TechTalk.SpecFlow;

namespace ForUBS.Tests.Features
{
    [Binding]
    public class CommonSteps
    {
        private readonly BrowserNavigation BrowserNavigation;
        private readonly PrivacySettingsSteps PrivacySettingsSteps;

        public CommonSteps(BrowserNavigation browserNavigation, PrivacySettingsSteps PrivacySettingsSteps)
        {
            this.BrowserNavigation = browserNavigation;
            this.PrivacySettingsSteps = PrivacySettingsSteps;
        }

        [When(@"User opens (.*) page")]
        [Given(@"User opens (.*) page")]
        public void GivenUserOpensHomePage(PagesEnum pages)
        {
            switch (pages)
            {
                case PagesEnum.Home:
                    BrowserNavigation.GoToUrl(Constants.Url.HOME_PAGE);
                    break;
                case PagesEnum.Contact:
                    BrowserNavigation.GoToUrl(Constants.Url.CONTACT_PAGE);
                    break;
            }
        }

        [When(@"User is on (.*) Page")]
        [Given(@"User is on (.*) Page")]
        public void GivenUserIsOnHomePage(PagesEnum pages)
        {
            switch (pages)
            {
                case PagesEnum.Home:
                    BrowserNavigation.GoToUrl("https://www.ubs.com");
                    break;
                case PagesEnum.Contact:
                    BrowserNavigation.GoToUrl("https://www.ubs.com/global/en/contact/ubs-staff-misconduct");
                    break;
            }
            this.PrivacySettingsSteps.UserAgreesToAllPrivacySettings();
        }
    }
}
