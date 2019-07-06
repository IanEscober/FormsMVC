using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Model;
using DesignPatterns.Controller;

namespace DesignPatterns.Tests.Controller
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void Controller_Should_Initialize_View()
        {
            var controller = new DesignPatternsController();

            var result = controller.View;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void SortInput_Should_Update_View()
        {
            var controller = new DesignPatternsController();
            var view = controller.View;

            var result = controller.SortInput(new DesignPatternsModel());

            Assert.AreNotSame(view, result);
        }
    }
}
