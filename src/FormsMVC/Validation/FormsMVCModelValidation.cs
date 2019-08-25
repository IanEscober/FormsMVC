using System;
using System.Text.RegularExpressions;
using FormsMVC.Model;
using FormsMVC.Sorting.Types;

namespace FormsMVC.Validation
{
    public static class FormsMVCModelValidation
    {
        public static bool IsValid(this FormsMVCModel model)
        {
            if (model != null)
            {
                if (!string.IsNullOrEmpty(model.Input))
                {
                    return
                        !Regex.IsMatch(model.Input, @"[^A-Za-z]") &&
                        Enum.IsDefined(typeof(SorterTypes), model.SortType);
                }
            }
            return false;
        }
    }
}
