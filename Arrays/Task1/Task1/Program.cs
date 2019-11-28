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

        static decimal[] PriceCalculator(decimal[] productPrice, int[] productAmount)
        {
            // Määritetään taulukko productTotalPrice. Taulukon koko määräytyy tuotteiden määrän mukaan
            decimal[] productTotalPrice = new decimal[productAmount.Length];
            for (int i = 0; i < productAmount.Length; i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
            }
            return productTotalPrice;
        }
        static void PrintPrice()
        {

        }
    }
}