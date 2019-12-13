using System;

namespace SosialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa Hetun oikeellisuuden.");
            string userInput = " 300252 - 308 T   ";

            userInput = RemoveSpaces(userInput);
            if (IsValidLenght(userInput))
            {
                if (IsValidDate(userInput))
                {
                    int idNumber = InputParser(userInput);
                    char getLastChar = GetUserInputChkMark(userInput);
                    bool isOK = IsValidID(idNumber, getLastChar);
                    PrintResult(isOK);
                }

            }
            else
            {
                Console.WriteLine("Tarkasta hetun oikeellisuus - liikaa merkkejä");
            }
        }

        static bool IsValidDate(string userInput)
        {
            //131052-308T
            bool result = false;
            // 
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2,2);
            string year = userInput.Substring(4, 2);
            string century = userInput.Substring(6, 1);

            if(century == "-")
            {
                year = "19" + year;
            }
            else if(century=="A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("Väärä vuosisata");
            }

            // Tarkastetaan päivämäärän oikeellisuus try-catch lohkossa
            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                result = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return result;
        }
        static bool IsValidLenght(string userInput)
        {
            return userInput.Length == 11;

            //if (userInput.Length == 11)
            //    return true;
            //else
            //    return false;

        }

        static string RemoveSpaces(string userInput)
        {
            string result = userInput.Replace(" ","");
            return result;
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
