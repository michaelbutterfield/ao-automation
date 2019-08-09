using OpenQA.Selenium;

namespace ao.framework.common.Selenium.Elements
{
    using common.Elements.Common;

    public class Button : Element
    {
        public Button(By myLocator, string elementName, string pageName) : base(myLocator, elementName, pageName) { }
    }
}
