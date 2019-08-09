namespace ao.framework.selenium.Application
{
    using Pages;

    class DesktopWebsite
    {
        public static BoardsPage BoardsPage { get; private set; }

        static DesktopWebsite()
        {
            BuildPages();
        }

        private static void BuildPages()
        {
            BoardsPage = new BoardsPage();
        }
    }
}
