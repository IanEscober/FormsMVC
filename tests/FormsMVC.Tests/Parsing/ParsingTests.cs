using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormsMVC.Model;
using FormsMVC.Parsing;
using FormsMVC.Sorting.Types;

namespace FormsMVC.Tests.Parsing
{
    [TestClass]
    public class ParsingTests
    {
        [DataRow("abc", 0)]
        [DataRow("ABC", 1)]
        [DataTestMethod]
        public void Parse_Should_Convert_Args_To_Model(string input, int index)
        {
            var value = new SortEventArgs { Input = input, SortTypeIndex = index };
            var expectedValue = new FormsMVCModel { Input = input, SortType = (SorterTypes)index, Output = null };

            var result = value.Parse();

            //For simplicity only
            Assert.IsTrue(DeepEqual(expectedValue, result));
        }

        private bool DeepEqual(FormsMVCModel expected, FormsMVCModel result) =>
            expected.Input == result.Input &&
            expected.SortType == result.SortType &&
            expected.Output == result.Output;
    }
}
