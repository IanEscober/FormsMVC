//Reference
//https://www.w3resource.com/csharp-exercises/searching-and-sorting-algorithm/searching-and-sorting-algorithm-exercise-9.php

using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Algorithm.Sorters
{
    public class QuickSorter : ISorter
    {
        public string Sort(string input) =>
            PerformSort(ref input, 0, input.Length - 1);

        public Task<string> SortAsync(string input) =>
            Task.Run(() => PerformSort(ref input, 0, input.Length - 1));

        private string PerformSort(ref string input, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(ref input, start, end);

                if (pivot > 1)
                {
                    _ = PerformSort(ref input, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    _ = PerformSort(ref input, pivot + 1, end);
                }
            }

            return input;
        }

        private int Partition(ref string input, int start, int end)
        {
            var builder = new StringBuilder(input);

            char pivot = builder[start];
            while (true)
            {

                while (builder[start] < pivot)
                {
                    start++;
                }

                while (builder[end] > pivot)
                {
                    end--;
                }

                if (start < end)
                {
                    if (builder[start] == builder[end])
                    {
                        return end;
                    }

                    char temp = builder[start];
                    builder[start] = builder[end];
                    builder[end] = temp;
                    input = builder.ToString();
                }
                else
                {
                    return end;
                }
            }
        }
    }
}
