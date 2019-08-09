namespace ao.framework.selenium.Application.Pages
{
    using common.Selenium.Elements;
    using common.Page;
    using OpenQA.Selenium;

    public class ListingPage : Page
    {
        public Text SearchTitle;
        public Text ShowAllProducts;
        public Button SilverFilterOption;

        public ListingPage() : base("Boards")
        {
            BuildPage();
        }

        private void BuildPage()
        {
            SearchTitle = new Text(By.XPath("//h1[@id='SeoTitle']"), "Search Plus Any Filters", name);
            ShowAllProducts = new Text(By.XPath("//a[@id='showAllProductsDetail']"), "Browse all Products", name);
            SilverFilterOption = new Button(By.XPath("//li[@id='fv_silver']"), "Silver Filter Option", name);
        }

        public void FilterByBrand(string FilterXpath)
        {
            Button FilterByBrand = new Button(By.XPath(FilterXpath), "Filter By Brand", name);
            FilterByBrand.Click();
        }

    }
}
