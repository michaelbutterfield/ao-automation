using NHamcrest;
using TechTalk.SpecFlow;

namespace ao.framework.selenium.Test.StepDefinitions
{
    using Application;
    using common.Utilities;


    [Binding]
    public class ListingPageSteps
    {
        [When]
        public void I_select_the_specific_brand_P0(string BrandFilter)
        {
            RuntimeTestData.Add("Brand", BrandFilter);

            string Brand = BrandFilter.ToLower();
            string CompleteXpath = string.Format("//li[@id='fv_{0}']", Brand);

            DesktopWebsite.ListingPage.FilterByBrand(CompleteXpath);
        }

        [Then]
        public void the_washing_machines_will_be_successfully_filtered()
        {
            string Brand = RuntimeTestData.GetAsString("Brand");
            string Colour = RuntimeTestData.GetAsString("Colour");

            string ExpectedSearchTerm = string.Format("{0} {1} Washing Machines", Colour, Brand);
            string ActualSearchTerm = DesktopWebsite.ListingPage.SearchTitle.GetElementText();

            string StepDesc = string.Format("Asserting actual --{0}-- is equal to expected --{1}--", ActualSearchTerm, ExpectedSearchTerm);
            TestHelper.AssertThat(ActualSearchTerm, Is.EqualTo(ExpectedSearchTerm), StepDesc);

        }
    }
}
