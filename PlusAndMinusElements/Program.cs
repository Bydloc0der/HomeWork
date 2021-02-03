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
            int[] nums = { 4, -5, -7, 2, 3 };
            methods(nums);
            Console.ReadKey();
        }

        static void methods(int[] nums)
        {
            int plusArraySize = 3; // переменная отражает количество положительных элементов, в заложенном массиве.
            int minusArraySize = 2; // // переменная отражает количество отрицательных элементов, в заложенном массиве.
            int[] plusnumbers = new int [plusArraySize]; // массив с положительными элементами
            int[] minusnumbers= new int [minusArraySize]; // массив с отрицательными элементами
            int alpha = 0; // переменная, дающая  номер положительному элементу
            int omega = 0; // переменная, дающая  номер отрицательному элементу

            for (int a = 0; a < nums.Length; ++a)
            {
                if (nums[a] < 0)
                {
                    minusnumbers[omega] = nums[a];
                    ++omega;
                }

                else if (nums[a] > 0)
                {
                    plusnumbers[alpha] = nums[a];
                    ++alpha;
                }
            }
            Console.Write("[");

            for (int c = 0; c < plusnumbers.Length; ++c)
            {
                Console.Write($"{plusnumbers[c]}");

                if (c < plusnumbers.Length-1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("] \n");
            Console.Write("[");

            for (int e = 0; e < minusnumbers.Length; ++e)
            {
                Console.Write($"{minusnumbers[e]}");

                if (e < minusnumbers.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
        }
    }
}
