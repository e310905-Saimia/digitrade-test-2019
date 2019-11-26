using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber=0;
            int sequenceOfNumber=0;

            Console.WriteLine("Ohjelma palauttaa syötetyistä luvuista suurimman ja kertoo monentenako se syötettiin");
            string resultMessage = MaxNumberCalculator(ref maxNumber, ref sequenceOfNumber);
            Console.WriteLine($"Syötit seuraavat luvut:\n {resultMessage}");
            Console.WriteLine($"Suurin {maxNumber} oli {sequenceOfNumber}. luku.");
        }

        static string MaxNumberCalculator(ref int maxNumber, ref int sequenceOfNumber)
        {
            //maxNumber=0;
            //sequenceOfNumber=0;
            string message = string.Empty;

            Console.WriteLine("Syötä 10 kokonaislukua");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}. ");
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput, out int userValue);

                if (isNumber)
                {
                    // generoidaan palautettava viesti syötetyistä luvuista
                    message = $"{message}  {userValue}";

                    // Selvitetään 
                    if (userValue > maxNumber)
                    {
                        maxNumber = userValue;
                        sequenceOfNumber = i + 1;
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte, syötä luku");
                    i--;
                }
            }
            return message;
        }
    }
}
