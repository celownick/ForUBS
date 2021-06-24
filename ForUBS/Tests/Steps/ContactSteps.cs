using FluentAssertions;
using ForUBS.Pages.ContactPage;
using TechTalk.SpecFlow;

namespace ForUBS.Tests.Features
{
    [Binding]
    public class ContactSteps
    {
        private readonly ContactPageActions ContactPageActions;

        public ContactSteps(ContactPageActions ContactPageActions)
        {
            this.ContactPageActions = ContactPageActions;
        }

        [Given(@"User fill personal details form without legal notice confirmation")]
        [When(@"User fill personal details form without legal notice confirmation")]
        public void WhenUserFillPersonalDetailsFormWithoutLegalNoticesConfirmation()
        {
            this.ContactPageActions.fillFullForm();
        }

        [Then(@"legal notice confirmation is required")]
        public void ThenLegalNoticeConfirmationIsRequired()
        {
            this.ContactPageActions.isLegalNoticeConfirmationRequired().Should().Be(true);
        }

        [Then(@"user remains on the same page")]
        public void ThenUserRemainsOnTheSamePage()
        {
            this.ContactPageActions.isReportMisconductHeaderDisplayed().Should().Be(true);
        }

        [When(@"user clicks submit button on 'Report misconduct' page")]
        public void WhenUserClicksSubmitButtonOnPage()
        {
            this.ContactPageActions.clickSubmitForm();
        }
    }
}