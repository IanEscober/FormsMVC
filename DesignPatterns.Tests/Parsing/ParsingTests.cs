using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Model;
using DesignPatterns.Parsing;
using DesignPatterns.Sorting.Types;

namespace DesignPatterns.Tests.Parsing
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
            var expectedValue = new DesignPatternsModel { Input = input, SortType = (SorterTypes)index, Output = null };

            var result = value.Parse();

            //For simplicity only
            Assert.IsTrue(DeepEqual(expectedValue, result));
        }

        private bool DeepEqual(DesignPatternsModel expected, DesignPatternsModel result) =>
            expected.Input == result.Input &&
            expected.SortType == result.SortType &&
            expected.Output == result.Output;
    }
}
