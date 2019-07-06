using System;
using System.Text.RegularExpressions;
using DesignPatterns.Model;
using DesignPatterns.Sorting.Types;

namespace DesignPatterns.Validation
{
    public static class DesignPatternsModelValidation
    {
        public static bool IsValid(this DesignPatternsModel model)
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
