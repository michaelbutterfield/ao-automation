using TechTalk.SpecFlow;

namespace ao.framework.selenium.Test.StepDefinitions
{
    using common.Utilities;
    using Application;

    [Binding]
    public class WashingMachinePageSteps
    {
        [When]
        public void I_filter_the_search_by_the_colour_silver()
        {
            RuntimeTestData.Add("Colour", "Silver");

            if (DesktopWebsite.WashingMachinePage.SilverFilterOption.Exists())
            {
                DesktopWebsite.WashingMachinePage.SilverFilterOption.Click();
                DesktopWebsite.WashingMachinePage.ShopNow.Click();
            }
            else if (DesktopWebsite.ListingPage.ShowAllProducts.Exists())
            {
                DesktopWebsite.ListingPage.SilverFilterOption.Click();
            }
        }
    }
}
