using System.Threading;

namespace WikipediaFramework
{
    public class LanguageLandingPage
    {
        public class Language
        {
            public static bool IsEnglish() => PageUrlContains("en");
            public static bool IsJapanese() => PageUrlContains("ja");
            public static bool IsDanish() => PageUrlContains("de");
            public static bool IsSpanish() => PageUrlContains("es");
            public static bool IsRussian() => PageUrlContains("ru");
            public static bool IsFrench() => PageUrlContains("fr");
            public static bool IsItalian() => PageUrlContains("it");
            public static bool IsChinese() => PageUrlContains("zh");
            public static bool IsPortugese() => PageUrlContains("pt");
            public static bool IsPolish() => PageUrlContains("pl");

            private static bool PageUrlContains(string urlSubString, int timeout=5000)
            {
                int currentWaitTime = 0;
                while (!Browser.Instance.Url.Contains("/" + urlSubString + ".") && currentWaitTime < timeout)
                {
                    currentWaitTime++;
                    Thread.Sleep(1);
                }
                var urlPortions = Browser.Instance.Url.Split('.');
                return urlPortions[0].EndsWith(urlSubString);
            }
        }
    }
}
