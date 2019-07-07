using System;
using System.Threading.Tasks;
using DesignPatterns.Model;
using DesignPatterns.Sorting;
using DesignPatterns.Sorting.Types;
using DesignPatterns.Sorting.Sorters;

namespace DesignPatterns.Service
{
    public class SortingService : ISortingService
    {
        private SorterContext _sorterContext;

        public SortingService()
        {
            _sorterContext = null;
        }

        public string ApplySorting(DesignPatternsModel model)
        {
            _sorterContext = SorterContextProvider(model.SortType);
            var output = _sorterContext.Sort(model.Input);
            return output;
        }

        public async Task<string> ApplySortingAsync(DesignPatternsModel model)
        {
            _sorterContext = SorterContextProvider(model.SortType);
            var output = await _sorterContext.SortAsync(model.Input);
            return output;
        }

        private SorterContext SorterContextProvider(SorterTypes sortType)
        {
            switch (sortType)
            {
                case SorterTypes.Bubble:
                    return new SorterContext(new BubbleSorter());
                case SorterTypes.Merge:
                    return new SorterContext(new MergeSorter());
                default:
                    throw new TypeLoadException("Cannot identify sorting type");
            }
        }
    }
}
