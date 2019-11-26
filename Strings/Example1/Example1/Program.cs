using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijononkäsittely esimerkki");
            string message = "Hello World!";

            // Tulostetaan message -muuttujen merkit yksitellen näytölle
            Console.WriteLine($"{message} on {message.Length} merkkiä.");

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
