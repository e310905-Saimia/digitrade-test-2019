using System;

namespace FactorialExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variables
            int n = 0;
            int fact = 1;

            // Tulostetaan viesti käyttäjälle
            Console.WriteLine("Kertoman laskenta");
            Console.Write("Minkä luvun kertoma lasketaan? ");

            // Luetaan käyttäjän syöte ja pakotetaan se integer muotoon
            n = int.Parse(Console.ReadLine());

            // Ehto, jossa testataan käyttäjän syöttämän arvo
            // Ohjelman logiikka
            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                // silmukka, jossa lasketaan kertoman arvo
                while (n > 0)
                {
                    fact = fact * n; // lasketaan kertoma joka kierroksella uudestaan
                    n = n - 1; //vähennetään arvoa yhdellä
                }
                // Tulosta vastaus näytölle
                Console.WriteLine("Vastaus: " + fact);
            }
        }
    }
}
