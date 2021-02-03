using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusAndMinusElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 1 };
            methods(nums);
            Console.ReadKey();
        }

        static void methods(int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("Введены не верные данные");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (nums.Length <= 0)
            {
                Console.WriteLine("Введены не верные данные");
                Console.ReadKey();
                Environment.Exit(0);
            }
            foreach (int g in nums)
            {
                if (g == 0)
                {
                    Console.WriteLine("Введены не верные данные. 0 - ни отрицательное, ни положительное число");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            int positiveElement = 0; // переменная отражает количество положительных элементов, в заложенном массиве.
            int negativeElement = 0;  // переменная отражает количество отрицательных элементов, в заложенном массиве.

            for (int b = 0; b < nums.Length; ++b)
            {
                if (nums[b] > 0)
                {
                    ++positiveElement;
                }

                else if (nums[b] < 0)
                {
                    ++negativeElement;
                }
            }
            int[] plusNumbers = new int[positiveElement]; // массив с положительными элементами
            int[] minusNumbers = new int[negativeElement]; // массив с отрицательными элементами
            int positiveCounter = 0; // переменная, дающая  номер положительному элементу
            int negativeCounter = 0; // переменная, дающая  номер отрицательному элементу

            for (int a = 0; a < nums.Length; ++a)
            {
                if (nums[a] < 0)
                {
                    minusNumbers[negativeCounter] = nums[a];
                    ++negativeCounter;
                }

                else if (nums[a] > 0)
                {
                    plusNumbers[positiveCounter] = nums[a];
                    ++positiveCounter;
                }
            }
            Console.Write("[");

            for (int c = 0; c < plusNumbers.Length; ++c)
            {
                Console.Write($"{plusNumbers[c]}");

                if (c < plusNumbers.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("] \n");
            Console.Write("[");

            for (int e = 0; e < minusNumbers.Length; ++e)
            {
                Console.Write($"{minusNumbers[e]}");

                if (e < minusNumbers.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
        }
    }
}
