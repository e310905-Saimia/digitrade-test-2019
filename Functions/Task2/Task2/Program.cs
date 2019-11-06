using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää kahdesta luvusta pinemmän minimi -funktion avulla");
            Console.Write("Syötä 1. luku: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Syötä 2. luku: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Luku {GetMinNumber(x,y)} on pienempi kuin {GetMaxNumber(x,y)}.");
        }

        /// <summary>
        /// Compare two numbers and return min number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>min number</returns>
        static int GetMinNumber(int firstNumber, int secondNumber)
        {
            return firstNumber < secondNumber? firstNumber: secondNumber;

            /*if (firstNumber < secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
            */
        }

        /// <summary>
        /// Compare two numbers and return max number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>max number</returns>
        static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            int result;
            if (firstNumber > secondNumber)
            {
                result = firstNumber;
            }
            else
            {
                result = secondNumber;
            }

            return result;
        }
    }
}
