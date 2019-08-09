using TechTalk.SpecFlow;

namespace ao.framework.selenium.Test.StepDefinitions
{
    using Application;
    using common.Utilities;

    [Binding]
    public sealed class AOExampleTest
    {
        [Given]
        public void I_navigate_to_the_AO_home_page()
        {
            SeleniumHelper.GoToUrl("https://ao.com/");
        }

        [Given]
        public void I_am_on_the_AO_home_page()
        {
            DesktopWebsite.AOHomePage.Header.SiteLogo.WaitUntilExists();
            DesktopWebsite.AOHomePage.AssertPageTitleIs("ao.com | Washing Machines | TVs | Laptops | Delivering Tomorrow");
        }

        [When]
        public void I_search_for_P0(string SearchTerm)
        {
            DesktopWebsite.AOHomePage.Header.SearchBox.SendKeys(SearchTerm);
            DesktopWebsite.AOHomePage.Header.SearchButton.Click();
        }
    }
}
