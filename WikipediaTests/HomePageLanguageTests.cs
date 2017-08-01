using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikipediaFramework;

namespace WikipediaTests
{
    [TestClass]
    public class HomePageLanguageTests : CommonTestMethods
    {
        [TestMethod]
        public void Select_English_Language()
        {
            WikipediaHomePage.SelectLanguage.English();
            Assert.IsTrue(LanguageLandingPage.Language.IsEnglish(), "Language of page was not english");
        }

        [TestMethod]
        public void Select_Japanese_Language()
        {
            WikipediaHomePage.SelectLanguage.Japanese();
            Assert.IsTrue(LanguageLandingPage.Language.IsJapanese(), "Language of page was not japanese");
        }

        [TestMethod]
        public void Select_Danish_Language()
        {
            WikipediaHomePage.SelectLanguage.Danish();
            Assert.IsTrue(LanguageLandingPage.Language.IsDanish(), "Language of page was not danish");
        }

        [TestMethod]
        public void Select_Spanish_Language()
        {
            WikipediaHomePage.SelectLanguage.Spanish();
            Assert.IsTrue(LanguageLandingPage.Language.IsSpanish(), "Language of page was not spanish");
        }

        [TestMethod]
        public void Select_Russian_Language()
        {
            WikipediaHomePage.SelectLanguage.Russian();
            Assert.IsTrue(LanguageLandingPage.Language.IsRussian(), "Language of page was not russian");
        }

        [TestMethod]
        public void Select_French_Language()
        {
            WikipediaHomePage.SelectLanguage.French();
            Assert.IsTrue(LanguageLandingPage.Language.IsFrench(), "Language of page was not french");
        }

        [TestMethod]
        public void Select_Italian_Language()
        {
            WikipediaHomePage.SelectLanguage.Italian();
            Assert.IsTrue(LanguageLandingPage.Language.IsItalian(), "Language of page was not italian");
        }

        [TestMethod]
        public void Select_Chinese_Language()
        {
            WikipediaHomePage.SelectLanguage.Chinese();
            Assert.IsTrue(LanguageLandingPage.Language.IsChinese(), "Language of page was not chinese");
        }

        [TestMethod]
        public void Select_Portugese_Language()
        {
            WikipediaHomePage.SelectLanguage.Portugese();
            Assert.IsTrue(LanguageLandingPage.Language.IsPortugese(), "Language of page was not portugese");
        }

        [TestMethod]
        public void Select_Polish_Language()
        {
            WikipediaHomePage.SelectLanguage.Polish();
            Assert.IsTrue(LanguageLandingPage.Language.IsPolish(), "Language of page was not polish");
        }
    }
}
