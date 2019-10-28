using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmen luvun lajittelu!");
            // Tietojen kysely
            Console.Write("Syötä 1. luku: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä 2. luku: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Syötä 3. luku: ");
            int z = int.Parse(Console.ReadLine());

            string userInput = $"Input: {x}, {y}, {z}";
            Console.WriteLine(userInput);
            Console.WriteLine("-------------------");
            string sortedOutput;

            // Logiikka, jolla ratkaistaan ongelma
            if (x <= y)
            {
                if (z > y)
                {
                    // 123
                    sortedOutput = $"Order: {x}, {y}, {z}";
                }
                else if (z < x)
                {
                    // 312
                    sortedOutput = $"Order: {z}, {x}, {y}";
                }
                else
                {
                    // 132
                    sortedOutput = $"Order: {x}, {z}, {y}";
                }
            }
            else if (x > y)
            {
                if (z > x)
                {
                    // 213 
                    sortedOutput = $"Order: {y}, {x}, {z}";
                }
                else if (z < y)
                {
                    // 321
                    sortedOutput = $"Order: {z}, {y}, {x}";
                }
                else
                {
                    // 231
                    sortedOutput = $"Order: {y}, {z}, {x}";
                }
            }
            else
            {
                sortedOutput = "Oops";
            }

            // Tulostetaan vastaus

            Console.WriteLine(sortedOutput);
        }
    }
}
