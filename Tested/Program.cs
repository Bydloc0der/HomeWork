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
            int[] nums = {4,4,1,1,1,1,1,2,2,2,2 };
            int result = GetBiggestNumber(nums);
            Console.ReadKey();
        }

        static int GetBiggestNumber(int[] nums)
        {
            int counter = 0; // переменная фиксирует наибольшее количество одинаковых элементов.
            int bigOneNumber = 0; // переменная обозначает значание элемента, который больше всех встечается в массиве

            for (int a = 0; a < nums.Length; ++a)
            {
                int clones = 0; // переменная обозначает количество одинаковых элементов. 
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
