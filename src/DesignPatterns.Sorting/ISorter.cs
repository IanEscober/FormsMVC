using System.Threading.Tasks;

namespace DesignPatterns.Sorting
{
    public interface ISorter
    {
        string Sort(string input);
        Task<string> SortAsync(string input);
    }
}
