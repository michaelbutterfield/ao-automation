namespace ao.framework.selenium.Application.Pages
{
    using common.Selenium.Elements;
    using common.Page;
    using OpenQA.Selenium;

    public class ListingPage : Page
    {
        public Text SearchTitle;

        public ListingPage() : base("Boards")
        {
            BuildPage();
        }

        private void BuildPage()
        {
            SearchTitle = new Text(By.XPath("//h1[@id='SeoTitle']"), "Search Plus Any Filters", name);
        }

        public void FilterByBrand(string BrandXpath)
        {
            Button FilterByBrand = new Button(By.XPath(BrandXpath), "Filter By Brand", name);
            FilterByBrand.Click();
        }

    }
}
