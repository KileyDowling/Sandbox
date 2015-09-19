using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class logic
    {
        public int binarySearch(int[] setOfNums, int selectedNum)
        {
            int max = setOfNums.Length - 1;
            int min = 0;
            int search = max / 2;
            int count = 0;

            while (min <= max)
            {
                Console.WriteLine("Searching at index {0}...", search);
                if (setOfNums[search] < selectedNum)
                {
                    min = search + 1;
                    search = (max + min) / 2;
                    count++;
                    Console.WriteLine("Loop number: {0}", count);
                }
                else if (setOfNums[search] > selectedNum)
                {
                    max = search - 1;
                    search = (max + min)/2;
                    count++;
                    Console.WriteLine("Loop number: {0}", count);
                }
                else
                {
                    count++;
                    Console.WriteLine("Total Loops: {0}", count);
                    return search;
                }
            }
            Console.WriteLine("\nNumber not found");
            return -1;
        }
    }
}
