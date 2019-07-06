using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Model;
using DesignPatterns.Validation;
using DesignPatterns.Sorting.Types;

namespace DesignPatterns.Tests.Validation
{
    [TestClass]
    public class ValidationTests
    {
        [DataRow("234$", 0)]
        [DataRow("abc ipo", 0)]
        [DataRow("&%%453 jsdbfn", 0)]
        [DataTestMethod]
        public void IsValid_WithInvalidInput_Should_Return_False(string input, int index)
        {
            var value = new DesignPatternsModel { Input = input, SortType = (SorterTypes)index, Output = null };

            var result = value.IsValid();

            Assert.IsFalse(result);
        }

        [DataRow("abc", 3)]
        [DataRow("abc", 40)]
        [DataRow("abc", 100)]
        [DataTestMethod]
        public void IsValid_WithInvalidIndex_Should_Return_False(string input, int index)
        {
            var value = new DesignPatternsModel { Input = input, SortType = (SorterTypes)index, Output = null };

            var result = value.IsValid();

            Assert.IsFalse(result);
        }

        [DataRow("ABC", 0)]
        [DataRow("abc", 1)]
        [DataRow("ajscaadbfn", 0)]
        [DataTestMethod]
        public void IsValid_WithValidInputAndIndex_Should_Return_True(string input, int index)
        {
            var value = new DesignPatternsModel { Input = input, SortType = (SorterTypes)index, Output = null };

            var result = value.IsValid();

            Assert.IsTrue(result);
        }
    }
}
