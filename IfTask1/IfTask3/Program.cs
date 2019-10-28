using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla sekä tarkastaa onko luku parillinen tai pariton.");
            Console.Write("Syötä luku: ");
            
            int userInputNumber = int.Parse(Console.ReadLine());
            if (userInputNumber < 0)
            {
                Console.Write($"Numero {userInputNumber} on negatiivinen, ");
            }
            else
            {
                if (userInputNumber > 0)
                {
                    Console.Write($"Numero {userInputNumber} on positiivinen, ");
                }
                else
                {
                    Console.Write($"Numero {userInputNumber} on nolla, ");
                }
            }


            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine("se on parillinen");
            }
            else
            {
                Console.WriteLine("se on pariton");
            }
        }
    }
}
