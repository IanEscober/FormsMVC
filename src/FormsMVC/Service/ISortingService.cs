using System.Threading.Tasks;
using FormsMVC.Model;

namespace FormsMVC.Service
{
    public interface ISortingService
    {
        string ApplySorting(FormsMVCModel model);
        Task<string> ApplySortingAsync(FormsMVCModel model);
    }
}