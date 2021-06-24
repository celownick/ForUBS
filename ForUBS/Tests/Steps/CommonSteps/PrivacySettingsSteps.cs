
using FluentAssertions;
using ForUBS.Enums;
using ForUBS.Pages.PrivacySettingsPage;
using TechTalk.SpecFlow;

namespace ForUBS.Tests.Features
{
    [Binding]
    public sealed class PrivacySettingsSteps
    {
        private readonly PrivacySettingsPageActions privacySettingsPageActions;

        public PrivacySettingsSteps(PrivacySettingsPageActions privacySettingsPageActions)
        {
            this.privacySettingsPageActions = privacySettingsPageActions;
        }

        [When(@"user agrees to all privacy settings")]
        public void UserAgreesToAllPrivacySettings()
        {
            this.privacySettingsPageActions.ClickAcceptAllButton();
        }

        [Then(@"privacy settings pop up windows is (.*)")]
        public void ThenPrivacySettingsPopUpWindowsIs(ConditionsEnum conditions)
        {
            switch (conditions)
            {
                case ConditionsEnum.Displayed:
                    this.privacySettingsPageActions.IsPrivacySettingsPopUpDisplayed().Should().Be(true);
                    break;
                case ConditionsEnum.NotDisplayed:
                    this.privacySettingsPageActions.IsPrivacySettingsPopUpNotDisplayed().Should().Be(true);
                    break;
            }
        }
    }
}
