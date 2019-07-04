using System.Threading.Tasks;

namespace DesignPatterns.Algorithm
{
    public class SorterContext
    {
        private readonly ISorter _sorter;

        public SorterContext(ISorter sorter) =>
            _sorter = sorter;
        
        public string Sort(string input) =>
            _sorter.Sort(input);

        public Task<string> SortAsync(string input) =>
            _sorter.SortAsync(input);
    }
}
