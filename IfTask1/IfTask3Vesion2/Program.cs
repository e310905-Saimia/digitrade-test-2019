using System;

namespace IfTask3Vesion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla sekä tarkastaa onko luku parillinen tai pariton.");
            Console.Write("Syötä luku: ");
            string isSignNegativeOrPositive = "Positiivinen";
            string isEvenOdd = "Parillinen";
            int userInputNumber = int.Parse(Console.ReadLine());

            if(userInputNumber==0)
                Console.WriteLine($"Numero {userInputNumber} on nollaluku");
            else if (userInputNumber < 0)
            {
                isSignNegativeOrPositive = "Negatiivinen";
            }
            else
            {
                isSignNegativeOrPositive = "Positiivinen";
            }

            if (userInputNumber % 2 == 0)
            {
                isEvenOdd = "Parillinen";
            }
            else
            {
                isEvenOdd = "Pariton";
            }

            Console.WriteLine($"Numero {userInputNumber} on {isSignNegativeOrPositive} ja se on {isEvenOdd}");      

        }
    }
}
