using System;
using OpenQA.Selenium;

namespace ForUBS.Pages.HomePage
{
    public class HomePageElements
    {
        public By UbsLogo => By.ClassName("logo__img--default");

        public By WealthManagementHeader => By.XPath("//ul[@id='mainmenu']//button[contains(text(),'Wealth Management')]");

        public By AssetsManagementHeader => By.XPath("//ul[@id='mainmenu']//button[contains(text(),'Asset Management')]");

        public By InvestmentBankHeader => By.XPath("//ul[@id='mainmenu']//button[contains(text(),'Investment Bank')]");

        public By AboutUsHeader => By.XPath("//ul[@id='mainmenu']//button[contains(text(),'About us')]");

        public By CareersHeader => By.XPath("//ul[@id='mainmenu']//button[contains(text(),'Careers')]");

        public By ContactHeader => By.XPath("//ul[@id='supportingnav']//button[contains(text(),'Contact')]");

        public By MainDomicileDropdown => By.Id("domicileButton");

        public By ContinentDomicileDropdown =>
            By.XPath("(//ul[@id='metanavigation-navContent0']//button[contains(text(),'Domicile')])[1]");

        public By CountryDomicileDropdown =>
            By.XPath("(//ul[@id='metanavigation-navContent0']//button[contains(text(),'Domicile')])");

        public By ContinentSelector(string continent)
        {
            return By.XPath(String.Format("(//ul[@id='metanavigation-navContent0']//button[contains(text(),'Domicile')])[1]/parent::li//button[contains(text(), '{0}')]", continent.Replace("_"," ")));
        }

        public By CountrySelector(string country) =>
            By.XPath(string.Format("(//ul[@id='metanavigation-navContent0']//button[contains(text(),'Domicile')])[1]/parent::li//li/a[contains(text(),'{0}')]", country));

        public By HomePageTitle => By.CssSelector(".header__title .header__hlTitle");
    }
}
