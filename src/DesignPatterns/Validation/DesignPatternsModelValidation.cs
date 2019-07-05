using DesignPatterns.Model;

namespace DesignPatterns.Validation
{
    public static class DesignPatternsModelValidation
    {
        public static bool IsValid(this DesignPatternsModel model) =>
            !string.IsNullOrEmpty(model.Input);
    }
}
