using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfThreeDigitNumbers;///массив, в котором будет количество трехзначных чисел, уменьшающихся в 9 раз, при зачеркивании средней цифры
            int numberOfDigitsDecreasingNineTimes = SortThreeDigitNumbers(out arrayOfThreeDigitNumbers);
            Console.WriteLine($"Количество трёхзначных чисел: {numberOfDigitsDecreasingNineTimes}");
            Console.ReadKey();
        }
        /// <summary>
        /// метод возвращает одномерный массив.
        /// </summary>
        /// <param name="arrayofthreedigitnumbers">массив, который заполнится количестом трёхзначных чисел, уменьшающихся в 9 раз, при зачеркивании средней цифры</param>
        static int SortThreeDigitNumbers(out int[] arrayOfThreeDigitNumbers)
        {
            int numberOfDigitsDecreasingNineTimes = 0;//переменная, отражающая количество трехзначных чисел, уменьшающихся в 9 раз, при зачеркивании средней цифры
            Console.Write("Трёхзначные числа, которые уменьшаются в 9 раз, при зачеркивании средней цифры:\n");

            for (int a = 100; a < 999; ++a)
            {

                if (a % 9 == 0 && a / 100 * 10 + a % 10 == a / 9)
                {
                    Console.WriteLine($"-{a}");
                    ++numberOfDigitsDecreasingNineTimes;
                }
            }
            arrayOfThreeDigitNumbers = new int[numberOfDigitsDecreasingNineTimes];


            for (int b = 100; b < 999; ++b)
            {

                if (b % 9 == 0 && b / 100 * 10 + b % 10 == b / 9)
                {

                    for (int c = 0; c < numberOfDigitsDecreasingNineTimes; ++c)
                    {
                        arrayOfThreeDigitNumbers[c] = b;
                    }
                }
            }

            return numberOfDigitsDecreasingNineTimes;
        }
    }
}
