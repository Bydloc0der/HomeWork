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

        static void methods(int[] plus)
        {
            int[] plusnumbers = { };
            int[] minusnumbers= { };
            int alpha = 0;
            int omega = 0;

            for (int a = 0; a < plus.Length; ++a)
            {
                if (plus[a] < 0)
                {
                    plusnumbers[omega] = plus[a];
                    ++omega;
                }

                else if (plus[a] > 0)
                {
                    minusnumbers[alpha] = plus[a];
                    ++alpha;
                }
            }

            foreach (int c in plusnumbers)
            {
                Console.WriteLine(plusnumbers[c]);
            }

            foreach (int b in minusnumbers)
            {
                Console.WriteLine(minusnumbers[b]);
            }
        }
    }
}
