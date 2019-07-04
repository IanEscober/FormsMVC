//Reference
//https://gist.github.com/nakov/b4663efc3a6092cb03ca

using System.Threading.Tasks;

namespace DesignPatterns.Algorithm.Sorters
{
    public class MergeSorter : ISorter
    {
        public string Sort(string input) =>
            PerformSort(input, 0, input.Length - 1);

        public Task<string> SortAsync(string input) =>
            Task.Run(() => PerformSort(input, 0, input.Length - 1));

        private string PerformSort(string input, int start, int end)
        {
            if (start < end)
            {
                int middle = (end + start) / 2;
                string left = PerformSort(input, start, middle);
                string right = PerformSort(input, middle + 1, end);
                string merged = Merge(left, right);
                return merged;
            }
            return input[start].ToString();
        }

        private string Merge(string left, string right)
        {
            var merged = new char[left.Length + right.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    merged[mergedIndex++] = left[leftIndex++];
                }
                else
                {
                    merged[mergedIndex++] = right[rightIndex++];
                }
            }

            while (leftIndex < left.Length)
            {
                merged[mergedIndex++] = left[leftIndex++];
            }

            while (rightIndex < right.Length)
            {
                merged[mergedIndex++] = right[rightIndex++];
            }

            return new string(merged);
        }
    }
}
