using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Näppäin yhdistelmiä tämä ei tunnista
            Console.WriteLine("Ohjelma ei näytä, mitä merkkejä kirjoitat tai mitä painikkeita painat.");
            Console.WriteLine("ESC keskeyttää merkkien kirjoituksen ja näet mitä kirjoitit.");
            Console.Write("Aloita kirjoitaminen: ");
            ConsoleKeyInfo cki;
            string s = string.Empty;
            do
            {
                cki = Console.ReadKey(true);
                s += cki.Key.ToString();
            } while (cki.Key != ConsoleKey.Escape);
            Console.WriteLine($"\nKirjoitit merkit {s}");
        }
    }
}
