using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikipediaFramework;

namespace WikipediaTests
{
    [TestClass]
    public class HomePagePartnerSiteTests : CommonTestMethods
    {
        [TestMethod]
        public void Load_Wikibooks()
        {
            WikipediaHomePage.SelectPartnerSite.Wikibooks();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikibooks.org/"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Commons()
        {
            WikipediaHomePage.SelectPartnerSite.Commons();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://commons.wikimedia.org/wiki/Main_Page"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikivoyage()
        {
            WikipediaHomePage.SelectPartnerSite.Wikivoyage();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikivoyage.org/"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wiktionary()
        {
            WikipediaHomePage.SelectPartnerSite.Wiktionary();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wiktionary.org/"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikinews()
        {
            WikipediaHomePage.SelectPartnerSite.Wikinews();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikinews.org/"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikidata()
        {
            WikipediaHomePage.SelectPartnerSite.Wikidata();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikidata.org/wiki/Wikidata:Main_Page"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikiversity()
        {
            WikipediaHomePage.SelectPartnerSite.Wikiversity();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikiversity.org/"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikiquote()
        {
            WikipediaHomePage.SelectPartnerSite.Wikiquote();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.wikiquote.org/"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_MediaWiki()
        {
            WikipediaHomePage.SelectPartnerSite.MediaWiki();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://www.mediawiki.org/wiki/MediaWiki"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikisource()
        {
            WikipediaHomePage.SelectPartnerSite.Wikisource();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://wikisource.org/wiki/Main_Page"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_Wikispecies()
        {
            WikipediaHomePage.SelectPartnerSite.Wikispecies();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://species.wikimedia.org/wiki/Main_Page"), "An unexpected partner site has opened");
        }

        [TestMethod]
        public void Load_MetaWiki()
        {
            WikipediaHomePage.SelectPartnerSite.MetaWiki();
            Assert.IsTrue(PartnerSite.ValidateUrl("https://meta.wikimedia.org/wiki/Main_Page"), "An unexpected partner site has opened");
        }

    }
}
