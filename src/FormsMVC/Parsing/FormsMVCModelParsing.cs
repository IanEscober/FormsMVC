using FormsMVC.Model;
using FormsMVC.Sorting.Types;

namespace FormsMVC.Parsing
{
    public static class FormsMVCModelParsing
    {
        public static FormsMVCModel Parse(this SortEventArgs sortEventArgs) =>
            new FormsMVCModel
            {
                Input = sortEventArgs.Input,
                SortType = (SorterTypes)sortEventArgs.SortTypeIndex
            };
    }
}
