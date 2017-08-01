using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaFramework
{
    public class WikipediaHomePage
    {
        public static bool IsDisplayed
        {
            get
            {
                var pageTitle = Browser.Instance.FindElement(By.XPath(".//h1[contains(@class, 'central-textlogo') and contains(@title, 'Wikipedia')]"));
                return pageTitle.Displayed;
            }
        }

        public static void LoadPage()
        {
            Browser.Instance.Navigate().GoToUrl("https://www.wikipedia.org/");
        }

        public static void EnterSearchString(string searchTerm)
        {
            var searchField = Browser.Instance.FindElement(By.Id("searchInput"));
            searchField.SendKeys(searchTerm);
            var searchBtn = Browser.Instance.FindElement(By.XPath(".//button[@type='submit']"));
            searchBtn.Click();
        }

        public class SelectLanguage
        {
            public static void English() => SelectTheLanguage("en");
            public static void Japanese() => SelectTheLanguage("ja");
            public static void Danish() => SelectTheLanguage("de");
            public static void Spanish() => SelectTheLanguage("es");
            public static void Russian() => SelectTheLanguage("ru");
            public static void French() => SelectTheLanguage("fr");
            public static void Italian() => SelectTheLanguage("it");
            public static void Chinese() => SelectTheLanguage("zh");
            public static void Portugese() => SelectTheLanguage("pt");
            public static void Polish() => SelectTheLanguage("pl");

            private static void SelectTheLanguage(string language)
            {
                var languageLink = Browser.Instance.FindElement(By.Id("js-link-box-" + language));
                languageLink.Click();
            }
        }

        public class SelectPartnerSite
        {
            public static void Wikibooks() => SelectPS("Wikibooks");
            public static void Commons() => SelectPS("Commons");
            public static void Wikivoyage() => SelectPS("Wikivoyage");
            public static void Wiktionary() => SelectPS("Wiktionary");
            public static void Wikinews() => SelectPS("Wikinews");
            public static void Wikidata() => SelectPS("Wikidata");
            public static void Wikiversity() => SelectPS("Wikiversity");
            public static void Wikiquote() => SelectPS("Wikiquote");
            public static void MediaWiki() => SelectPS("MediaWiki");
            public static void Wikisource() => SelectPS("Wikisource");
            public static void Wikispecies() => SelectPS("Wikispecies");
            public static void MetaWiki() => SelectPS("Meta-Wiki");

            private static void SelectPS(string psName)
            {
                var psDivs = Browser.Instance.FindElements(By.ClassName("other-project"));
                foreach (var projectDiv in psDivs)
                {
                    var title = projectDiv.FindElement(By.XPath(".//span[contains(@class, 'other-project-title')]"));
                    if (title.Text.Equals(psName))
                    {
                        projectDiv.FindElement(By.TagName("a")).Click();
                        return;
                    }
                }
                throw new System.ArgumentException("partner site not found");
            }
        }
    }
}
