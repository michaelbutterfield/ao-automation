namespace ao.framework.selenium.Application.Pages
{
    using common.Page;
    using Sections;

    public class AOHomePage : Page
    {
        //Headers
        public Header Header;

        public AOHomePage() : base("Boards")
        {
            BuildSections();
        }
        private void BuildSections()
        {
            Header = new Header();
        }
    }
}
