using OpenQA.Selenium;
using System;

namespace ao.framework.common.Selenium.Elements
{
    using common.Elements.Common;

    public class Link : Element
    {
        public Link(By myLocator, String elementName, String pageName) : base(myLocator, elementName, pageName) { }
    }
}
