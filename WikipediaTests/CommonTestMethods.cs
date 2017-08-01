using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikipediaFramework;

namespace WikipediaTests
{
    [TestClass]
    public class CommonTestMethods
    {
        private TestContext _testContextInstance;
        private string _browser = "Firefox";

        [TestInitialize]
        public void Initialize()
        {
            if (TestContext.Properties.Contains("browser"))
            {
                _browser = TestContext.Properties["browser"].ToString();
            }

            Browser.Initialize(_browser);
            WikipediaHomePage.LoadPage();
        }

        public TestContext TestContext
        {
            get
            {
                return _testContextInstance;
            }
            set
            {
                _testContextInstance = value;
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            Browser.Close();
        }
    }
}
