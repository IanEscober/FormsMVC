using System;
using System.Threading.Tasks;
using DesignPatterns.Sorting;
using DesignPatterns.Sorting.Types;
using DesignPatterns.Sorting.Sorters;

namespace DesignPatterns.Service
{
    public static class SortingService
    {
        public static string Sort(this string input, SorterTypes sortType)
        {
            var sorter = SortContextProvider(sortType);
            var output = sorter.Sort(input);
            return output;
        }

        public static async Task<string> SortAsync(this string input, SorterTypes sortType)
        {
            var sorter = SortContextProvider(sortType);
            var output = await sorter.SortAsync(input);
            return output;
        }

        private static SorterContext SortContextProvider(SorterTypes sortType)
        {
            switch (sortType.ToString())
            {
                case nameof(SorterTypes.Bubble):
                    {
                        return new SorterContext(new BubbleSorter());
                    }
                case nameof(SorterTypes.Quick):
                    {
                        return new SorterContext(new QuickSorter());
                    }
                case nameof(SorterTypes.Merge):
                    {
                        return new SorterContext(new MergeSorter());
                    }
                default:
                    throw new Exception("Cannot identify sorting type");
            }
        }
    }
}
