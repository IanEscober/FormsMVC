//Reference
//http://anh.cs.luc.edu/170/notes/CSharpHtml/sorting.html#bubble-sort

using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Algorithm.Sorters
{
    public class BubbleSorter : ISorter
    {
        public string Sort(string input) =>
            PerfromSort(input);

        public Task<string> SortAsync(string input) =>
            Task.Run(() => PerfromSort(input));

        private string PerfromSort(string input)
        {
            var builder = new StringBuilder(input);
            char temp;

            for (int j = 0; j <= builder.Length - 2; j++)
            {
                for (int i = 0; i <= builder.Length - 2; i++)
                {
                    if (builder[i] > builder[i + 1])
                    {
                        temp = builder[i + 1];
                        builder[i + 1] = builder[i];
                        builder[i] = temp;
                    }
                }
            }

            return builder.ToString();
        }

    }
}
