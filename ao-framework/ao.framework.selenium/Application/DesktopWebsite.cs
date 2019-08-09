namespace ao.framework.selenium.Application
{
    using Pages;

    public class DesktopWebsite
    {
        public static AOHomePage AOHomePage { get; private set; }
        public static ListingPage ListingPage { get; private set; }
        public static WashingMachinePage WashingMachinePage { get; private set; }

        static DesktopWebsite()
        {
            BuildPages();
        }

        private static void BuildPages()
        {
            AOHomePage = new AOHomePage();
            ListingPage = new ListingPage();
            WashingMachinePage = new WashingMachinePage();
        }
    }
}
