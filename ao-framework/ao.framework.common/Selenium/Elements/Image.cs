using OpenQA.Selenium;

namespace ao.framework.common.Selenium.Elements
{
    using common.Elements.Common;

    public class Image : Element
    {
        public Image(By myLocator, string elementName, string pageName) : base(myLocator, elementName, pageName) { }
    }
}
