using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Model;
using DesignPatterns.Controller;
using System.Threading.Tasks;

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
        public async Task SortInput_Should_Update_View()
        {
            var controller = new DesignPatternsController();
            var view = controller.View;

            var result = await controller.SortInput(new DesignPatternsModel());

            Assert.AreNotSame(view, result);
        }
    }
}
