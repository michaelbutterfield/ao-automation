namespace ao.framework.common.Page
{
    using Utilities;
    using NHamcrest;

    public abstract class Page
    {
        protected string name;

        protected Page(string name)
        {
            this.name = name;
        }

        public void AssertPageTitleIs(string expectedTitle)
        {
                string actualSiteTitle = SeleniumHelper.GetWebDriver().Title;
                string StepDesc = string.Format("Assert that Expected Site Title: {0} is equal to Actual Site Title: {1}", expectedTitle, actualSiteTitle);
                TestHelper.AssertThat(expectedTitle, Is.EqualTo(actualSiteTitle), StepDesc);
        }
    }

    public class Section
    {
        protected string name;

        protected Section(string name)
        {
            this.name = name;
        }
    }
}
