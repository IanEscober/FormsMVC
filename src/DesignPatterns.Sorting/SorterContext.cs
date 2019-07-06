using System;
using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public class SorterContext
    {
        private readonly ISorter _sorter;

        public SorterContext(ISorter sorter) =>
            _sorter = sorter ?? throw new NullReferenceException("Sorter");
        
        public string Sort(string input) =>
            _sorter.Sort(input);

        public Task<string> SortAsync(string input) =>
            _sorter.SortAsync(input);
    }
}
