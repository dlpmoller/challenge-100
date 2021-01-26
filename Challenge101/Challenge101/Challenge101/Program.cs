using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge101
{
    class Program
    {
        //Sets up and makes an instance of a givenNumbers array, maximum being a 100. For reliability's sake, a conditional to end the input phase when 100 is hit is a good idea.
        public static int?[] givenNumbers = new int?[100];
        //Just a reminder to the user of how many numbers they've input
        public static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Input your numbers. Ends when a numerically presented number isn't submitted:");
            CheckInput(Console.ReadLine());
        }


        public static void CheckInput(string input)
        {
            try
            {
                //Add the input number to the givenNumbers array
                Console.WriteLine(givenNumbers[count]);
                givenNumbers[count] = int.Parse(input);
                count++;
                Console.WriteLine("You have input " + count + " numbers so far.");
                //Just to make sure it goes back to the state of listening to the input.
                CheckInput(Console.ReadLine());
            }
            //Using an error catch to end the input phase and move to sorting.
            catch (FormatException)
            {
                int? high = null;
                int? low = null;
                int index = 0;

                //for loop to work through the array to find highest and lowest numbers
                for (int i = 0; i < givenNumbers.Length; i++)
                {
                    int? thisNumber = givenNumbers[i];
                    if (!high.HasValue || thisNumber > high.Value)
                    {
                        high = thisNumber;
                        index = i;
                    }
                    if (!low.HasValue || thisNumber < low.Value)
                    {
                        low = thisNumber;
                        index = i;
                    }
                }
                Console.WriteLine("These are the highest and lowest numbers that has been submitted:");
                Console.WriteLine("The highest being " + high + ", with the lowest being " + low);
                Console.WriteLine("Press any key to quit.");
                Console.ReadKey();
            }
        }
    }
}