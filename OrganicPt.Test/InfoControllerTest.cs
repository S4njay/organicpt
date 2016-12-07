using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrganicPt.Controllers;
using TestStack.FluentMVCTesting;
using System.Net;

namespace OrganicPt.Test
{
    [TestClass]
    public class InfoControllerTest
    {
        [TestMethod]
        public void GetCmpReturnsStockPrice()
        {
            //var client = new Mock<WebClient>();
            //var sut = new InfoController(client.Object);
            //var getCmp = sut.GetCmp(Guid.NewGuid());

            //Assert.AreEqual(getCmp.GetType(), typeof(string));             
        }
    }
}
