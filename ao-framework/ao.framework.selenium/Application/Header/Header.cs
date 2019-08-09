using OpenQA.Selenium;

namespace ao.framework.selenium.Application.Sections
{
    using common.Page;
    using common.Selenium.Elements;

    public class Header : Section
    {
        public InputBox SearchBox { get; private set; }
        public Button SearchButton { get; private set; }
        public Image SiteLogo { get; private set; }

        public Header() : base("Header")
        {
            BuildSections();
        }

        private void BuildSections()
        {
            SearchBox = new InputBox(By.Id("searchAOL"), "Search Box", name);
            SearchButton = new Button(By.XPath("//a[@aria-label='Search products']"), "Magnifying Glass Search", name);
            SiteLogo = new Image(By.XPath("//div[@class='aoSiteLogoLink']"), "AO Header Logo", name);
        }
    }
}