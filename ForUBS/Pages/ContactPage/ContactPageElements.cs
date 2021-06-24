using System;
using OpenQA.Selenium;

namespace ForUBS.Pages.ContactPage
{
    public class ContactPageElements
    {
        public By Iframe => By.XPath("//iframe[@src='https://secure.ubs.com/app/LRH/en']");
        public By Title_Mrs => By.XPath("//label[contains(@for,'Title_1') and text()='Mrs/Ms']");
        public By FirstName => By.Id("Firstname");
        public By LastName => By.Id("Lastname");
        public By Phone => By.Id("Phone");
        public By Email => By.Id("Email");
        public By Address => By.Id("Address");
        public By City => By.Id("City");
        public By PostalCode => By.Id("Zip");
        public By CountryDropdown => By.Id("Country");
        public By RegionDropdown => By.Id("Region");
        public By DescriptionOfMisconduct => By.Id("Concern");
        public By ConfirmationRequired => By.XPath("//input[@class='checkbox__input inputtext__input-is-error']");
        public By CountryFromDropdown(String country) => By.XPath(string.Format("//select[contains(@id,'Country')]//option[text()='{0}']", country));
        public By RegionFromDropdown(String region) => By.XPath(string.Format("//select[contains(@id,'Region')]//option[text()='{0}']", region));
        public By ReportMisconductPageHeader => By.XPath("//h1[@class='pageheadline__hl pageheadline__hl--small']");
        public By SubmitFormButton => By.XPath("//span[contains(@class, 'actionbutton__txtbody') and text()='Submit']");
    }
}