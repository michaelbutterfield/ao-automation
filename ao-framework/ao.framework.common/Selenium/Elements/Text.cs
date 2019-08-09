using OpenQA.Selenium;

namespace ao.framework.common.Selenium.Elements
{
    using common.Elements.Common;

    public class Text : Element
    {
        public Text(By myLocator, string elementName, string pageName) : base(myLocator, elementName, pageName) { }
    }
}
