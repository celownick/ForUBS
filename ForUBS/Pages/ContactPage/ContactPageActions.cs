using Faker;
using ForUBS.Enums;


namespace ForUBS.Pages.ContactPage
{
    public class ContactPageActions : BaseActions
    {
        protected ContactPageElements ContactPageElements;
        public ContactPageActions(WebElements webElements, ContactPageElements ContactPageElements) : base(webElements)
        {
            this.ContactPageElements = ContactPageElements;
        }

        public void fillFullForm()
        {
            this.WebElements.SwitchToIframe(this.ContactPageElements.Iframe);
            this.WebElements.ClickDisplayedElement(this.ContactPageElements.Title_Mrs);
            this.WebElements.SendKeys(this.ContactPageElements.FirstName, Faker.Name.First());
            this.WebElements.SendKeys(this.ContactPageElements.LastName, Faker.Name.Last());
            this.WebElements.SendKeys(this.ContactPageElements.Phone, Faker.Phone.Number().Substring(0,12));
            this.WebElements.SendKeys(this.ContactPageElements.Email, Faker.Internet.Email());
            this.WebElements.SendKeys(this.ContactPageElements.Address, Faker.Address.StreetAddress());
            this.WebElements.SendKeys(this.ContactPageElements.City, Faker.Address.City());
            this.WebElements.SendKeys(this.ContactPageElements.PostalCode, Faker.Address.UkPostCode());
            this.setCountry();
            this.setRegion();
            this.WebElements.SendKeys(this.ContactPageElements.RegionDropdown, Faker.Name.First());
            this.WebElements.SendKeys(this.ContactPageElements.DescriptionOfMisconduct, Faker.Lorem.Sentence());
            this.WebElements.SwitchFromIframe();
        }

        private void setCountry()
        {
            this.WebElements.ClickDisplayedElement(this.ContactPageElements.CountryDropdown);
            this.WebElements.ClickDisplayedElement(
                this.ContactPageElements.CountryFromDropdown(Enum.Random<ContactCountriesEnum>().ToString()));
        }

        private void setRegion()
        {
            this.WebElements.ClickDisplayedElement(this.ContactPageElements.RegionDropdown);
            this.WebElements.ClickDisplayedElement(
                this.ContactPageElements.RegionFromDropdown(Enum.Random<ContactRegionEnum>().ToString()));
        }

        public bool isLegalNoticeConfirmationRequired()
        {
            this.WebElements.SwitchToIframe(this.ContactPageElements.Iframe);
            var attributeValue = this.WebElements.GetElement(this.ContactPageElements.ConfirmationRequired).GetAttribute("class").Contains("inputtext__input-is-error");
            this.WebElements.SwitchFromIframe();
            return attributeValue;
        }

        public bool isReportMisconductHeaderDisplayed()
        {
            return this.WebElements.GetElement(this.ContactPageElements.ReportMisconductPageHeader).Displayed;
        }

        public void clickSubmitForm()
        {
            this.WebElements.SwitchToIframe(this.ContactPageElements.Iframe);
            this.WebElements.ScrollAndClick(this.ContactPageElements.SubmitFormButton);
            this.WebElements.SwitchFromIframe();
        }
    }
}