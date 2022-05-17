using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 1, 2, 3, 3 };
            int[] secondArray = new int[] { 5, 2, 1, 4 };
            foreach (var resultItem in CalculateSymmetricDifference(firstArray, secondArray))
            {
                Console.WriteLine(resultItem);
            }
            Console.ReadKey();
        }

        public static int[] CalculateSymmetricDifference(int[] firstArray, int[] secondArray)
        {
            var result = new List<int>();
            var isPresent = false;
            foreach (var firstArrayItem in firstArray)
            {
                isPresent = false;
                foreach (var secondArrayItem in secondArray)
                {
                    if (firstArrayItem == secondArrayItem)
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (!isPresent && !result.Contains(firstArrayItem))
                {
                    result.Add(firstArrayItem);
                }
            }
            foreach (var secondArrayItem in secondArray)
            {
                isPresent = false;
                foreach (var firstArrayItem in firstArray)
                {
                    if (secondArrayItem == firstArrayItem)
                    {
                        isPresent = true;
                        break;
                    }
                }
                if (!isPresent && !result.Contains(secondArrayItem))
                {
                    result.Add(secondArrayItem);
                }
            }
            return result.ToArray();
        }
    }
}
