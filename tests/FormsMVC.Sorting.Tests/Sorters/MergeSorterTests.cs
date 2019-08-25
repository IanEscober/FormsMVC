using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsMVC.Sorting.Sorters;

namespace FormsMVC.Sorting.Tests.Sorters
{
    [TestClass]
    public class MergeSorterTests
    {
        [DataRow("bacsdasdwea", "aaabcddessw")]
        [DataRow("adadACCCAAaeredfds", "AAACCCaaaddddeefrs")]
        [DataRow("sadvv5434+=!sadnpop", "!+3445=aaddnoppssvv")]
        [DataTestMethod]
        public void Sort_Should_Sort_Input(string input, string sortedInput)
        {
            var value = input;
            var expectedValue = sortedInput;
            var sorter = new MergeSorter();

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
            var sorter = new MergeSorter();

            var result = await sorter.SortAsync(value);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
