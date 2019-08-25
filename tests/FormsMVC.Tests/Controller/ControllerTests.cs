using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using FormsMVC.Model;
using FormsMVC.Controller;
using FormsMVC.Service;

namespace FormsMVC.Tests.Controller
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void Controller_WithSortingSerivce_Should_Initialize_View()
        {
            var mockSortingService = new Mock<ISortingService>();
            var controller = new FormsMVCController(mockSortingService.Object);

            var result = controller.View;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Controller_WithOutSortingSerivce_Should_Throw()
        {
            ISortingService nullSortingService = null;

            Action act = () => new FormsMVCController(nullSortingService);

            Assert.ThrowsException<NullReferenceException>(act);
        }

        [TestMethod]
        public async Task SortInputAsync_Should_Update_View()
        {
            var mockSortingService = new Mock<ISortingService>();
            var controller = new FormsMVCController(mockSortingService.Object);
            var view = controller.View;

            var result = await controller.SortInputAsync(new FormsMVCModel());

            Assert.AreNotSame(view, result);
        }
    }
}
