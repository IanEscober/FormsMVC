using System.Threading.Tasks;

namespace FormsMVC.Sorting
{
    public interface ISorter
    {
        string Sort(string input);
        Task<string> SortAsync(string input);
    }
}
