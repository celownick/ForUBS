
using ForUBS.Drivers;

namespace ForUBS.Pages
{
    public class BrowserNavigation
    {
        private readonly DriverFactory driverFactory;

        public BrowserNavigation(DriverFactory driverFactory)
        {
            this.driverFactory = driverFactory;
        }
        public void GoToUrl(string url)
        {
            Waits.WaitForPageLoad(driverFactory.GetDriver());
            driverFactory.GetDriver().Navigate().GoToUrl(url);
        }
    }
}