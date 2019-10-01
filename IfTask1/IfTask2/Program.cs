using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumber = 0;
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen!");
            Console.Write("Syötä kokonaisluku: ");
            userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine($"Numero {userInputNumber} on parillinen");                
            }
            else
            {
                Console.WriteLine($"Numero {userInputNumber} on pariton");
            }
        }
    }
}
