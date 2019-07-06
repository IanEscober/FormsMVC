using DesignPatterns.Model;
using DesignPatterns.Sorting.Types;

namespace DesignPatterns.Parsing
{
    public static class DesignPatternsModelParsing
    {
        public static DesignPatternsModel Parse(this SortEventArgs sortEventArgs) =>
            new DesignPatternsModel
            {
                Input = sortEventArgs.Input,
                SortType = (SorterTypes)sortEventArgs.SortTypeIndex
            };
    }
}
