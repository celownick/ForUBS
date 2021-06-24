
using ForUBS.Drivers;
using TechTalk.SpecFlow;

namespace ForUBS.Hooks
{
    [Binding]
    public sealed class BeforeHook
    {
        
        [BeforeScenario]
        public static void BeforeScenario()
        {
            DriverFactory driver = new DriverFactory();
            driver.CreateDriver();
        }
    }
}