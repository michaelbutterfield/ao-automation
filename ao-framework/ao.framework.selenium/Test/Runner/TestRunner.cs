using TechTalk.SpecFlow;

namespace ao.framework.selenium.Test.Runner
{
    using common.Utilities;

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
        }

        [AfterScenario]
        static void AfterScenario()
        {
            SeleniumHelper.DestroyDriver();
            RuntimeTestData.Destroy();
        }
    }
}
