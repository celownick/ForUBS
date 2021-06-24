using ForUBS.Drivers;
using TechTalk.SpecFlow;

namespace ForUBS.Hooks
{
    [Binding]
    public sealed class AfterHook
    {

        private readonly DriverFactory driverFactory;


        public AfterHook(DriverFactory driverFactory)
        {
            this.driverFactory = driverFactory;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (driverFactory.GetDriver() != null)
            {
                driverFactory.GetDriver().Close();
                driverFactory.GetDriver().Quit();
            }
        }
    }
}