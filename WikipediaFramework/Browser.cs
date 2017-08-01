using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using System;

namespace WikipediaFramework
{
    public class Browser
    {
        public static IWebDriver Instance { get; set; }
        public static void Initialize(string testBrowser="chrome")
        {
            testBrowser = testBrowser.ToLower();
            if (testBrowser == "ie" || testBrowser == "internetexplorer")
            {
                Instance = new InternetExplorerDriver();
            }
            else if (testBrowser == "firefox")
            {
                FirefoxProfile ff = new FirefoxProfile();
                ff.SetPreference("network.proxy.type", (int)ProxyKind.AutoDetect);
                Instance = new FirefoxDriver(ff);
            }
            else if (testBrowser == "edge")
            {
                Instance = new EdgeDriver();
            }
            else
            {
                Instance = new ChromeDriver();
            }
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Instance.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

        public static void Close()
        {
            Instance.Quit();
        }
    }
}
