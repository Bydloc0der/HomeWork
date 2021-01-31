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
        }

        static void methods(int[] plus)
        {
            int[] plusnumbers;
            int[] minusnumbers;
            int alpha = 0;
            int omega = 0;

            for (int a = 0; a < plus.Length; ++a)
            {
                if (plus[a] < 0)
                {
                    plusnumbers[omega] = plus[a];
                }
            }
        }
    }
}
