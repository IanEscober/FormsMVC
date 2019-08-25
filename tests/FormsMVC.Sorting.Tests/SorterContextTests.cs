using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace FormsMVC.Sorting.Tests
{
    [TestClass]
    public class SorterContextTests
    {
        [TestMethod]
        public void SorterContext_WithSorter_Should_Initialize()
        {
            var mockSorter = new Mock<ISorter>();

            Action act = () => new SorterContext(mockSorter.Object);

            act();
        }

        [TestMethod]
        public void SorterContext_WithOutSorter_Should_Throw()
        {
            ISorter nullSorter = null;

            Action act = () => new SorterContext(nullSorter);

            Assert.ThrowsException<NullReferenceException>(act);
        }
    }
}
