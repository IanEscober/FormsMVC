using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Sorting.Types;
using DesignPatterns.Service;

namespace DesignPatterns.Tests.Service
{
    [TestClass]
    public class SortingServiceTests
    {
        [DataRow(SorterTypes.Bubble)]
        [DataRow(SorterTypes.Merge)]
        [DataTestMethod]
        public void Sort_Should_Sort_Input(SorterTypes sortType)
        {
            var value = "bacsdasdwea";
            var expectedValue = "aaabcddessw";

            var result = value.Sort(sortType);

            Assert.AreEqual(expectedValue, result);
        }

        [DataRow(SorterTypes.Bubble)]
        [DataRow(SorterTypes.Merge)]
        [DataTestMethod]
        public async Task SortAsync_Should_Sort_Input(SorterTypes sortType)
        {
            var value = "bacsdasdwea";
            var expectedValue = "aaabcddessw";

            var result = await value.SortAsync(sortType);

            Assert.AreEqual(expectedValue, result);
        }

        [DataRow((SorterTypes)345)]
        [DataRow((SorterTypes)100)]
        [DataTestMethod]
        public void Sort_WithInvalidSorter_Should_Throw(SorterTypes sortType)
        {
            var value = "bacsdasdwea";

            Action act = () => value.Sort(sortType);

            Assert.ThrowsException<TypeLoadException>(act);
        }

        [DataRow((SorterTypes)345)]
        [DataRow((SorterTypes)100)]
        [DataTestMethod]
        public async Task SortAsync_WithInvalidSorter_Should_Throw(SorterTypes sortType)
        {
            var value = "bacsdasdwea";

            var task = Task.Run(() => value.SortAsync(sortType));

            await Assert.ThrowsExceptionAsync<TypeLoadException>(() => task);
        }
    }
}
