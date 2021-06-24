using FluentAssertions;
using FluentAssertions.Execution;
using ForUBS.Enums;
using ForUBS.Pages.HomePage;
using TechTalk.SpecFlow;

namespace ForUBS.Tests.Features
{
    [Binding]
    public class HomePageSteps
    {
        private readonly HomePageAction HomePageAction;

        public HomePageSteps(HomePageAction HomePageAction)
        {
            this.HomePageAction = HomePageAction;
        }

        [Then(@"Home page is displayed")]
        public void ThenHomePageIsDisplayed()
        {
            using (new AssertionScope())
            {
                this.HomePageAction.IsWealthManagementHeaderDisplayed().Should().Be(true);
                this.HomePageAction.IsAssetsManagementHeaderDisplayed().Should().Be(true);
                this.HomePageAction.IsInvestmentBankHeaderDisplayed().Should().Be(true);
                this.HomePageAction.IsAboutUsHeaderDisplayed().Should().Be(true);
                this.HomePageAction.IsCareersHeaderDisplayed().Should().Be(true);
                this.HomePageAction.IsContactHeader().Should().Be(true);
            }
        }

        [When(@"User selects continent (.*) domicile")]
        public void WhenUserSelectsContinentDomicile(DomicileContinentEnum continent)
        {
            this.HomePageAction.SelectMainDomicileDropdown();
            this.HomePageAction.SelectContinentDomicile(continent);
        }

        [When(@"User selects country (.*) domicile")]
        public void WhenUserSelectsCountryDomicile(DomicileCountryEnum country)
        {
            this.HomePageAction.SelectCountryDomicile(country);
        }

        [Then(@"correct page (.*) is displayed")]
        public void ThenCorrectPageIsDisplayed(HomePageEnum homePageEnum)
        {
            this.HomePageAction.getHomePageTitle().Should().Be(homePageEnum.ToString());
        }

    }
}
