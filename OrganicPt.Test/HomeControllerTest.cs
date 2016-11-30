using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrganicPt.Controllers;
using TestStack.FluentMVCTesting;

namespace OrganicPt.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void RendersDefaultView()
        {
            var repo = new Mock<IRepository<Stock>>();
            var sut = new HomeController(repo.Object);
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();
        }
    }
}
