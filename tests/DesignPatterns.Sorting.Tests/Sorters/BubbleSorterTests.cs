using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Sorting.Sorters;

namespace DesignPatterns.Sorting.Tests.Sorters
{
    [TestClass]
    public class BubbleSorterTests
    {
        [DataRow("bacsdasdwea", "aaabcddessw")]
        [DataRow("adadACCCAAaeredfds", "AAACCCaaaddddeefrs")]
        [DataRow("sadvv5434+=!sadnpop", "!+3445=aaddnoppssvv")]
        [DataTestMethod]
        public void Sort_Should_Sort_Input(string input, string sortedInput)
        {
            var value = input;
            var expectedValue = sortedInput;
            var sorter = new BubbleSorter();

            var result = sorter.Sort(value);

            Assert.AreEqual(expectedValue, result);
        }

        [DataRow("bacsdasdwea", "aaabcddessw")]
        [DataRow("adadACCCAAaeredfds", "AAACCCaaaddddeefrs")]
        [DataRow("sadvv5434+=!sadnpop", "!+3445=aaddnoppssvv")]
        [DataTestMethod]
        public async Task SortAsync_Should_Sort_Input(string input, string sortedInput)
        {
            var value = input;
            var expectedValue = sortedInput;
            var sorter = new BubbleSorter();

            var result = await sorter.SortAsync(value);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
