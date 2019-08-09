using OpenQA.Selenium;

namespace ao.framework.selenium.Application.Pages
{
    using common.Selenium.Elements;
    using common.Page;

    public class WashingMachinePage : Page
    {
        public Button ShopNow;
        public Button SilverFilterOption;

        public WashingMachinePage() : base("Boards")
        {
            BuildPage();
        }

        private void BuildPage()
        {
            ShopNow = new Button(By.XPath("//a[@id='shopNow']"), "Shop Now", name);
            SilverFilterOption = new Button(By.XPath("//span[@class='optionText' and text()='Silver']"), "Silver Filter Option", name);
        }
    }
}
