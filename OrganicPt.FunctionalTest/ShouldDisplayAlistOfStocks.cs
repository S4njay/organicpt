using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace OrganicPt.FunctionalTest
{
    [TestClass]
    public class ShouldDisplayAlistOfStocks
    {
        [TestMethod]
        public void ShouldDisplayAtLeastOneRow()
        {
            BrowserHost.Instance.Application.Browser
                .Navigate()
                .GoToUrl(BrowserHost.RootUrl);

            var rows = BrowserHost.Instance.Application.Browser.FindElements(By.ClassName("row"));

            Assert.IsTrue(rows.Count > 0);
        }
    }
}
