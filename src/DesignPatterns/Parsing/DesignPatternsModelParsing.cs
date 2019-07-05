using System;
using DesignPatterns.Model;
using DesignPatterns.Sorting.Types;

namespace DesignPatterns.Parsing
{
    public static class DesignPatternsModelParsing
    {
        public static DesignPatternsModel Parse(this SortEventArgs sortEventArgs)
        {
            Enum.TryParse(sortEventArgs.SortType, out SorterTypes sortType);
            return new DesignPatternsModel
            {
                Input = sortEventArgs.Input,
                SortType = sortType
            };
        }
    }
}
