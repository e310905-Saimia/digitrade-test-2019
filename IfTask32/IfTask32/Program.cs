using System;

namespace IfTask32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N lukujen summan");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("FOR ---------------");
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("WHILE ---------------");

            int j = 0; // Laskurin määritys
            while(j < userInput) // Silmukan ehto. Silmukkaa tehdään niin pitkään kunnes se on epätosi
            {
                j++;  //Laskuri kasvatus yhdellä
                Console.WriteLine(j); // Tulostus                
            }

            Console.WriteLine("WHILE ikiluuppi---------------");

            int k = 0; // Laskurin määritys
            while (true) // Ikuluuppi
            {
                k++;  //Laskuri kasvatus yhdellä
                Console.WriteLine(k); // Tulostus
                if (k >= userInput) //Ehto silmukan lopetukselle
                    break;
            }

            Console.WriteLine("DO-WHILE ---------------");

            int n = 0;
            do
            {
                n++;
                Console.WriteLine(n);
            } while (n<userInput);

            Console.WriteLine("Ohjelman suoritus on päättynyt!");

        }
    }
}
