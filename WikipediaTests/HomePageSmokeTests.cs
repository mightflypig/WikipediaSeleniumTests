using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikipediaFramework;

namespace WikipediaTests
{
    [TestClass]
    public class HomePageSmokeTests : CommonTestMethods
    {
        [TestMethod]
        public void LoadHomePage()
        {
            Assert.IsTrue(WikipediaHomePage.IsDisplayed, "Wikipedia home page was not displayed");
        }

        [TestMethod]
        public void Search_For_Article()
        {
            WikipediaHomePage.EnterSearchString("Selenium");
            Assert.IsTrue(WikipediaArticlePage.PageHasTitle("Selenium"), "Page for selenium did not load");
        }

        [TestMethod]
        public void Load_Partner_Site()
        {
            WikipediaHomePage.SelectPartnerSite.Wikibooks();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikibooks.org/"), "URL was not as expected");
        }
    }
}
