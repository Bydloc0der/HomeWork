using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tested
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {};
            int result = GetBiggestNumber(nums);
            Console.ReadKey();
        }

        static int GetBiggestNumber(int[] nums)
        {
            if (nums == null)
            {
                Console.WriteLine("Введены не верные данные");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (nums.Length <= 0)
            {
                Console.WriteLine("Отсутствуют элементы в массиве");
                Console.ReadKey();
                Environment.Exit(0);
            }

            int counter = 0; // переменная фиксирует наибольшее количество одинаковых элементов.
            int bigOneNumber = 0; // переменная обозначает значание элемента, который больше всех встечается в массиве
            for (int a = 0; a < nums.Length; ++a)
            {
                int clones = 1; // переменная обозначает количество одинаковых элементов. 
                for (int b = 0; b < nums.Length; ++b)
                {

                    if ((nums[a] == nums[b]) && a != b)
                    {
                        ++clones;
                    }

                }
                if (clones > counter)
                {
                    bigOneNumber = nums[a];
                    counter = clones;
                }
            }
            return bigOneNumber;
        }
    }
}
