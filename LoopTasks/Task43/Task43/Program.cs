using System;

namespace Task43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satunnaislukugeneraattorin harjoittelua harjoitus 4.3");
   
            // Satunnaislukuolion luonti
            Random rnd = new Random();

            #region "Kaksi sisäkkäistä silmukkaa, jotka tulostavat riville satunnailukuja"
            // Silmukka, joka tulostaa rivit
            for (int r = 0; r < 4; r++)
            {
                Console.Write($"Rivi {r+1}: ");

                //Tulostaa satunnaisluvut riville
                for (int i = 0; i < 5; i++)
                {
                    if (i < 4)
                    {
                        Console.Write($"{rnd.Next(0, 51)}, ");
                    }
                    else
                    {
                        Console.WriteLine(rnd.Next(0, 51));                       
                    }
                }
                
            }
            #endregion


        }
    }
}
