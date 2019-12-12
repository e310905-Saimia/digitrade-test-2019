using System;

namespace SosialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa Hetun oikeellisuuden.");
            string userInput = "141052-308T";
            int idNumber =  InputParser(userInput);
            IsValidID(idNumber);

        }

        static int InputParser(string stringParser)
        {
            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6,1);

            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modChecker = idNumber % 31;

            Console.WriteLine(chkMark[modChecker]);
            return true;


        }















    }
}
