﻿using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko esimerkki");
            // Esitellään numbers taulukko
            int[] numbers = new int[] { 1, 3, 5, 7, 9 };

            // asetetaan arvo numbers taulukkoon
            numbers[4] = 11;

            // luetaan arvo taulukosta
            Console.WriteLine(numbers[2]);

            Console.WriteLine("Taulukon sisältö silmukassa");
            // luetaan arvot silmukassa
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // kutsutaan funktiota, joka asettaa arvot taulukkoon
            numbers = SetNumbers(5);

            Console.WriteLine("Kakkosen potenssit");
            // luetaan arvot silmukassa
            for (int i = 0; i <  numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        /// <summary>
        /// Asettaa taulukkoon arvoja
        /// arraySize on taulukon koko. 
        /// Palauttaa 2 pontenssit
        /// </summary>
        /// <returns></returns>
        static int[] SetNumbers(int arraySize)
        {
            int[] arrayPower = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                arrayPower[i] = (int)Math.Pow(2, i);
            }
            return arrayPower;
        }
    }
}
