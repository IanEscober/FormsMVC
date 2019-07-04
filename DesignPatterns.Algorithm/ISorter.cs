using System.Threading.Tasks;

namespace DesignPatterns.Algorithm
{
    public interface ISorter
    {
        string Sort(string input);
        Task<string> SortAsync(string input);
    }
}
