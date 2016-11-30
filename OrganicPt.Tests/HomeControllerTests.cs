using Moq;
using NUnit.Framework;
using OrganicPt;
using OrganicPt.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace OrganicPt.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void RendersDefaultView()
        {
            var repo = new Mock<IRepository<Stock>>();
            var sut = new HomeController(repo.Object);
            sut.WithCallTo(x => x.Index()).ShouldRenderDefaultView();            
        }
    }
}
