using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            logic newTest = new logic();
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();
            int selectedNum = int.Parse(input);

           int locationFound = newTest.binarySearch(numbers, selectedNum);
            if(locationFound >= 0)
                Console.WriteLine("\n{0} was found at location {1}", selectedNum,locationFound);
            Console.ReadLine();

        }
    }
}
