using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko harjoitus 1");
            // Esitellään ja alustetaan taulukko muuttujat
            decimal[] productPrice = new decimal[] { 7.96M, 72.0M, 99.90M };
            int[] productAmount = new int[] { 1, 3, 2 };
            decimal[] productTotalPrice = new decimal[3]; // Tässä asetetaan taulukon koko

            for (int i = 0; i < productAmount.Length; i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
            }

        }
    }
}