using System;

namespace arrayExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array esimerkki 2");
            Console.Write("Kuinka monta lukua arvotan? ");
            int size = int.Parse(Console.ReadLine());
            
            int[] arrayNumbers = new int[size];
            arrayNumbers = SetRandomNumbers(size, -10, 10);

            int[] arrayTable = SetRandomNumbers(5, -5, 0);

            int[] arrA = new int[] { 1, 3, 5, 7, 9, 11 };
            PrintArray(arrayNumbers);
            PrintArray(arrayTable);
            PrintArray(arrA);
            PrintArray(SetRandomNumbers(4, 0, 1));

         
            

        }

        /// <summary>
        /// Funktio arpoo halutun määrän luku taulukkoon, jonka k...
        /// lenght = taulukon koko
        /// minValue = alaraja
        /// maxValue = yläraja
        /// </summary>
        /// <param name="length"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static int[] SetRandomNumbers(int length, int minValue, int maxValue)
        {
            int[] numbers = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rnd.Next(minValue, maxValue + 1);
            }
            return numbers;
        }

        static void PrintArray(int[] arrX)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < arrX.Length; i++)
            {
                Console.WriteLine($"{i+1}. {arrX[i]}");
            }          
        }
    }
}
