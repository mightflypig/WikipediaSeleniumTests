using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WikipediaFramework
{
    public class PartnerSite
    {
        public static bool ValidateUrl(string urlToValidate, int timeout=5000)
        {
            int currentWaitTime = 0;
            while (!Browser.Instance.Url.Equals(urlToValidate) && currentWaitTime < timeout)
            {
                currentWaitTime++;
                Thread.Sleep(1);
            }
            return Browser.Instance.Url.Equals(urlToValidate);
        }
    }
}
