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
            int[] nums = { 4, 7, 2, 4, 3, 5, 1, 0, 1, 1, 8,1 };
            FindBigOne(nums);
            Console.ReadKey();
        }

        static void FindBigOne(int[] method)
        {
            int counter = 0;
            int result = 0;

            for (int a = 0; a < method.Length; ++a)
            {
                int clones = 0;

                for (int b = 0; b < method.Length; ++b)
                {

                    if ((method[a] == method[b]) && a != b)
                    {
                        ++clones;
                    }

                    if (clones > counter)
                    {
                        result = a;
                    }
                }
            }
            Console.WriteLine($"{method[result]}");
        }
    }
}
