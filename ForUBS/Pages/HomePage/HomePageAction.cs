using ForUBS.Enums;

namespace ForUBS.Pages.HomePage
{
    public class HomePageAction : BaseActions
    {
        private readonly HomePageElements HomePageElements;

        public HomePageAction(WebElements WebElements, HomePageElements HomePageElements) : base(WebElements)
        {
            this.HomePageElements = HomePageElements;
        }

        public bool IsWealthManagementHeaderDisplayed()
        {
            return this.WebElements.GetElement(this.HomePageElements.WealthManagementHeader).Displayed;
        }

        public bool IsAssetsManagementHeaderDisplayed()
        {
            return this.WebElements.GetElement(this.HomePageElements.AssetsManagementHeader).Displayed;
        }
        public bool IsInvestmentBankHeaderDisplayed()
        {
            return this.WebElements.GetElement(this.HomePageElements.InvestmentBankHeader).Displayed;
        }

        public bool IsAboutUsHeaderDisplayed()
        {
            return this.WebElements.GetElement(this.HomePageElements.AboutUsHeader).Displayed;
        }
        public bool IsCareersHeaderDisplayed()
        {
            return this.WebElements.GetElement(this.HomePageElements.CareersHeader).Displayed;
        }
        public bool IsContactHeader()
        {
            return this.WebElements.GetElement(this.HomePageElements.ContactHeader).Displayed;
        }

        public void SelectContinentDomicile(DomicileContinentEnum continent)
        {
            this.WebElements.ClickDisplayedElement(this.HomePageElements.ContinentDomicileDropdown);
            this.WebElements.GetElement(this.HomePageElements.ContinentSelector(continent.ToString().Replace("_", " "))).Click();
        }

        public void SelectCountryDomicile(DomicileCountryEnum country)
        {
            this.WebElements.ClickDisplayedElement(this.HomePageElements.CountryDomicileDropdown);
            this.WebElements.GetElement(this.HomePageElements.CountrySelector(country.ToString().Replace("_", " "))).Click();
        }

        public void SelectMainDomicileDropdown()
        {
            this.WebElements.ClickDisplayedElement(this.HomePageElements.MainDomicileDropdown);
        }

        public string getHomePageTitle()
        {
            return this.WebElements.GetDisplayedTextOfElement(this.HomePageElements.HomePageTitle);
        }
    }
}