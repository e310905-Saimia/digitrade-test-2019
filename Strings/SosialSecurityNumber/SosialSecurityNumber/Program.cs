using System;

namespace SosialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa Hetun oikeellisuuden.");
            string userInput = "131052-308T";
            int idNumber = InputParser(userInput);
            char getLastChar = GetUserInputChkMark(userInput);
            bool isOK = IsValidID(idNumber, getLastChar);
            PrintResult(isOK);
        }

        static char GetUserInputChkMark(string userInput)
        {
            return userInput[userInput.Length - 1];
        }

        static int InputParser(string stringParser)
        {
            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);

            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber, char userInputChkMark)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modChecker = idNumber % 31;

            // Vertailu onko käyttäjän syöttämä viimeinen merkki sama kuin laskettu
            if (chkMark[modChecker] == userInputChkMark)
                return true;
            else
                return false;

            // return chkMark[modChecker] == userInputChkMark;
        }

        static void PrintResult(bool isValidId)
        {
            if (isValidId)
                Console.WriteLine("Sotu on oikein!");
            else
                Console.WriteLine("Sotu on väärin!");
        }















    }
}
