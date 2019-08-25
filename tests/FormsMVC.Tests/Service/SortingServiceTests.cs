using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsMVC.Sorting.Types;
using FormsMVC.Model;
using FormsMVC.Service;

namespace FormsMVC.Tests.Service
{
    [TestClass]
    public class SortingServiceTests
    {
        [DataRow(SorterTypes.Bubble)]
        [DataRow(SorterTypes.Merge)]
        [DataTestMethod]
        public void ApplySorting_Should_Sort_Input(SorterTypes sortType)
        {
            var value = "bacsdasdwea";
            var expectedValue = "aaabcddessw";
            var sorter = new SortingService();
            var model = new FormsMVCModel { Input = value, SortType = sortType };

            var result = sorter.ApplySorting(model);

            Assert.AreEqual(expectedValue, result);
        }

        [DataRow(SorterTypes.Bubble)]
        [DataRow(SorterTypes.Merge)]
        [DataTestMethod]
        public async Task ApplySortingAsync_Should_Sort_Input(SorterTypes sortType)
        {
            var value = "bacsdasdwea";
            var expectedValue = "aaabcddessw";
            var sorter = new SortingService();
            var model = new FormsMVCModel { Input = value, SortType = sortType };

            var result = await sorter.ApplySortingAsync(model);

            Assert.AreEqual(expectedValue, result);
        }

        [DataRow((SorterTypes)345)]
        [DataRow((SorterTypes)100)]
        [DataTestMethod]
        public void ApplySorting_WithInvalidSorter_Should_Throw(SorterTypes sortType)
        {
            var value = "bacsdasdwea";
            var sorter = new SortingService();
            var model = new FormsMVCModel { Input = value, SortType = sortType };

            Action act = () => sorter.ApplySorting(model);

            Assert.ThrowsException<TypeLoadException>(act);
        }

        [DataRow((SorterTypes)345)]
        [DataRow((SorterTypes)100)]
        [DataTestMethod]
        public async Task ApplySortingAsync_WithInvalidSorter_Should_Throw(SorterTypes sortType)
        {
            var value = "bacsdasdwea";
            var sorter = new SortingService();
            var model = new FormsMVCModel { Input = value, SortType = sortType };

            var task = Task.Run(() => sorter.ApplySortingAsync(model));

            await Assert.ThrowsExceptionAsync<TypeLoadException>(() => task);
        }
    }
}
