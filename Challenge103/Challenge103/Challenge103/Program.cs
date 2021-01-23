using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge103
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a line that is either all lowercase or all uppercase.");
            Console.WriteLine("We'll know if it isn't.");
            CheckString(Console.ReadLine());
        }

        static void CheckString(string input)
        {
            int upperCaseCount = 0;
            char[] characters = input.ToCharArray();
            foreach (char item in characters)
            {
                if (Char.IsUpper(item))
                {
                    upperCaseCount++;
                }
            }

            if (upperCaseCount == characters.Length || upperCaseCount == 0)
            {
                Console.WriteLine("Yup. " + input + " is indeed what I asked for.");
            }
            else
            {
                Console.WriteLine("You just had to try, didn't you? " + input + " is a sorry mix of upper AND lower case.");
            }

            CheckString(Console.ReadLine());
        }
    }
}
