using OpenQA.Selenium;
using System;

namespace WikipediaFramework
{
    public class WikipediaArticlePage
    {
        public static bool PageHasTitle(string expectedTitle)
        {
            var titleField = Browser.Instance.FindElement(By.Id("firstHeading"));
            return String.Equals(titleField.Text, expectedTitle);
        }
    }
}
