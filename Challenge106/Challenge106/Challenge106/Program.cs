using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge106
{
    class Program
    {
        //Equating a letter with a number in an array of arrays. There is probably a way better method for this.
        static string[][] alphabetNumber = new string[][]
        {
            new string[] {"a","1"},
            new string[] {"b","2"},
            new string[] {"c","3"},
            new string[] {"d","4"},
            new string[] {"e","5"},
            new string[] {"f","6"},
            new string[] {"g","7"},
            new string[] {"h","8"},
            new string[] {"i","9"},
            new string[] {"j","10"},
            new string[] {"k","11"},
            new string[] {"l","12"},
            new string[] {"m","13"},
            new string[] {"n","14"},
            new string[] {"o","15"},
            new string[] {"p","16"},
            new string[] {"q","17"},
            new string[] {"r","18"},
            new string[] {"s","19"},
            new string[] {"t","20"},
            new string[] {"u","21"},
            new string[] {"v","22"},
            new string[] {"w","23"},
            new string[] {"x","24"},
            new string[] {"y","25"},
            new string[] {"z","26"},
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase. Please only use English, I don't know umlauts:");
            ConvertInput(Console.ReadLine());
        }

        static void ConvertInput(string input)
        {
            string processedInput = "";

            //Splitting the input into an array.
            char[] characters = input.ToLower().ToCharArray();
            
            foreach (var character in characters)
            {
                //Runs through the association array to match the character.
                foreach (var item in alphabetNumber)
                {
                    //If it's not on the list, move on.
                    if (Char.Parse(item[0]) == character)
                    {
                        //Try-catch in case something slips through.
                        try
                        {
                            processedInput += item[1] + " ";
                        }
                        catch (IndexOutOfRangeException)
                        {
                            processedInput += "- ";
                        }
                    }
                }
            }

            //Making sure the input doesn't become a negative value, in case of single special characters.
            if (processedInput.Length > 1)
            {
                Console.WriteLine(processedInput.Remove(processedInput.Length - 1, 1));
            }
            ConvertInput(Console.ReadLine());
        }
    }
}
