using System.Threading.Tasks;
using DesignPatterns.Model;

namespace DesignPatterns.Service
{
    public interface ISortingService
    {
        string ApplySorting(DesignPatternsModel model);
        Task<string> ApplySortingAsync(DesignPatternsModel model);
    }
}