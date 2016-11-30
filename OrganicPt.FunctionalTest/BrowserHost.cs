using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;

namespace OrganicPt.FunctionalTest
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl; 

        static BrowserHost()
        {
            Instance.Run("OrganicPt", 4223);

            RootUrl = Instance.Application.Browser.Url;
        }
    }
}
