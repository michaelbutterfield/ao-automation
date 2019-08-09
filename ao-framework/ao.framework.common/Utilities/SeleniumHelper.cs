using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ao.framework.common.Utilities
{
    public class SeleniumHelper
    { 
        private static IWebDriver Driver = null;
        public static TimeSpan DEFAULT_TIMEOUT = new TimeSpan(0, 0, 10);

        public static void DestroyDriver()
        {
            Driver.Quit();
            Driver = null;
        }

        public static string GetCurrentUrl()
        {
            return Driver.Url;
        }

        public static IWebElement GetElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        public static IReadOnlyCollection<IWebElement> GetElements(By locator)
        {
            return Driver.FindElements(locator);
        }

        public static IWebDriver GetWebDriver()
        {
            return Driver;
        }

        public static void GoToUrl(string Url)
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void Refresh()
        {
            Driver.Navigate().Refresh();
        }

        public static void Initialise(string browser)
        {
            browser = browser.ToLower();
            try
            {
                switch (browser)
                {
                    case "chrome":
                        {
                            ChromeOptions options = new ChromeOptions();
                            //options.AddArgument("--headless");
                            options.AddArgument("--window-size=1920,1080");
                            Driver = new ChromeDriver(options);
                            break;
                        }
                    case "firefox":
                        {
                            Driver = new FirefoxDriver();
                            break;
                        }
                    case "ie":
                        {
                            Driver = new InternetExplorerDriver();
                            break;
                        }
                    default:
                        throw new ArgumentException("Browser choice not set or choice incorrect: " + browser);
                }
            }
            catch (Exception e)
            {
                TestHelper.HandleException("Failed to start browser driver", e);
            }
            

            Driver.Manage().Window.Maximize();
        }
    }
}