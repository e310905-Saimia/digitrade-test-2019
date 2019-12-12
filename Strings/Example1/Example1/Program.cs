using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijononkäsittely esimerkki");
            string message = "  Hello World!  ";

            // Tulostetaan message -muuttujen merkit yksitellen näytölle
            Console.WriteLine($"{message} on {message.Length} merkkiä.");
            Console.WriteLine("----------");

            PrintMessage(message);
            Console.WriteLine("----------");

            //Poistetaan välilyönnit alusta ja lopusta
            string tempMessage = message.Trim();
            PrintMessage(tempMessage);
            Console.WriteLine("----------");

            tempMessage = tempMessage.ToUpper();
            PrintMessage(tempMessage);
            Console.WriteLine("----------");

            // Etsitään merkin kohta merkkijonosta
            int position = tempMessage.IndexOf(' ');
            Console.WriteLine($"Välilyönti löytyy kohdasta {position}");
            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.WriteLine(message[i]);
            //}


        }

        static void PrintMessage(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
    }
}
