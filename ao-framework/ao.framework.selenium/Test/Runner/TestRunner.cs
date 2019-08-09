using TechTalk.SpecFlow;
using training.automation.common.Utilities;

namespace ao.framework.selenium.Test.Runner
{
    [Binding]
    public class TestRunner
    {
        [BeforeScenario]
        static void BeforeScenario()
        {
            string feature = FeatureContext.Current.FeatureInfo.Title;
            if(!RuntimeTestData.ContainsKey("FeatureName"))
            {
                RuntimeTestData.Add("FeatureName", feature);
            }

            SeleniumHelper.Initialise("chrome");
            SeleniumHelper.GoToUrl("https://ao.com");
        }

        [AfterScenario]
        static void AfterScenario()
        {

            SeleniumHelper.DestroyDriver();
            RuntimeTestData.Destroy();
        }
    }
}
