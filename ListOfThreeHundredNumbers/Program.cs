using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfThreeDigitNumbers;///массив, в котором будет количество трехзначных чисел, уменьшающихся в 9 раз, при зачеркивании средней цифры
            int numberOfDigitsDecreasingNineTimes = SearchThreeDigitNumbers(out arrayOfThreeDigitNumbers);
            Console.WriteLine($"Количество трёхзначных чисел: {numberOfDigitsDecreasingNineTimes}");
            Console.ReadKey();
        }
        /// <summary>
        /// метод возвращает кол-во чисел трёхзначных, которые меньше в 9 раз, при зачеркивании средней цифры.
        /// </summary>
        /// <param name="arrayofthreedigitnumbers">массив, который заполнится количестом трёхзначных чисел, уменьшающихся в 9 раз, при зачеркивании средней цифры</param>
        static int SearchThreeDigitNumbers(out int[] arrayOfThreeDigitNumbers)
        {
            int numberOfDigitsDecreasingNineTimes = 0;//переменная, отражающая количество трехзначных чисел, уменьшающихся в 9 раз, при зачеркивании средней цифры

            for (int a = 100; a < 999; ++a)
            {
                if (a % 9 == 0 && a / 100 * 10 + a % 10 == a / 9)
                {
                    ++numberOfDigitsDecreasingNineTimes;
                }
            }

            arrayOfThreeDigitNumbers = new int[numberOfDigitsDecreasingNineTimes];
            int indexOfArray = numberOfDigitsDecreasingNineTimes - 1; // переменная отвечает за индекс в переменной, для присвоения значения.

            for (int b = 999; b > 100 ; --b)
            {
                if (b % 9 == 0 && b / 100 * 10 + b % 10 == b / 9)
                {
                    arrayOfThreeDigitNumbers[indexOfArray] = b;
                    --indexOfArray;
                }
            }
            return numberOfDigitsDecreasingNineTimes;
        }
    }
}
