using OpenQA.Selenium;

namespace ao.framework.selenium.Application.Pages
{
    using common.Page;
    using common.Selenium.Elements;
    using Sections;

    public class BoardsPage : Page
    {
        //Elements
        public Label BoardNotFound { get; private set; }
        public Button CreateNewBoard { get; private set; }
        public Text PersonalBoards { get; private set; }
        public Button Unstarred { get; private set; }
        public Button Starred { get; private set; }

        //Headers
        public Header Header;

        public BoardsPage() : base("Boards")
        {
            BuildPage();
            BuildSections();
        }
        private void BuildSections()
        {
            Header = new Header();
        }

        private void BuildPage()
        {
            BoardNotFound = new Label(By.XPath("//h1[contains(text(),'Board not found.')]"), "Board not found. message", name);
            CreateNewBoard = new Button(By.XPath("//button[@data-test-id='header-create-board-button']"), "Create Board... Button", name);
            PersonalBoards = new Text(By.XPath("//h3[text()='Personal Boards']"), "Personal Boards", name);
            Starred = new Button(By.XPath("//span[@class='icon-sm icon-star is-starred board-tile-options-star-icon']"), "Starred Board Button", name);
        }

    }
}
