using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge106
{
    class Program
    {
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

            char[] characters = input.ToLower().ToCharArray();
            
            foreach (var character in characters)
            {
                foreach (var item in alphabetNumber)
                {
                    if (Char.Parse(item[0]) == character)
                    {
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

            //TODO: Fix outofrange exception when there's just a single special character.
            Console.WriteLine(processedInput.Remove(processedInput.Length - 1, 1));
            ConvertInput(Console.ReadLine());
        }
    }
}
