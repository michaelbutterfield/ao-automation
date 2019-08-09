using OpenQA.Selenium;
using System;

namespace ao.framework.common.Selenium.Elements
{
    using common.Elements.Common;

    public class Label : Element
    {
        public Label(By myLocator, String elementName, String pageName) : base(myLocator, elementName, pageName) { }
    }
}
