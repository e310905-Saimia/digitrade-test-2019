using System;

namespace LoopTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            if (userInput < 0)
            {
                Console.WriteLine("Virheellinen syöte");
            }
            else
            {
                // Ohjelman logiikka, silmukka
                for (int i = 0; i < userInput; i++)
                {
                    sumOfNumbers = sumOfNumbers + (i + 1);
                }

                Console.WriteLine($"Vastaus: {sumOfNumbers}");
            }

        }
    }
}
