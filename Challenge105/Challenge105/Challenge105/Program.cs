using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numerical value of a month:");
            CheckMonth(Console.ReadLine());
        }

        static void CheckMonth (string input)
        {
            //Making sure a format exception won't happen.
            try
            {
                int parsedInput = int.Parse(input);
                string month;
                if (parsedInput <= 12 && parsedInput > 0)
                {
                    //This is probably a mess.
                    switch (parsedInput)
                    {
                        case 1:
                            month = "January";
                            break;
                        case 2:
                            month = "February";
                            break;
                        case 3:
                            month = "March";
                            break;
                        case 4:
                            month = "April";
                            break;
                        case 5:
                            month = "May";
                            break;
                        case 6:
                            month = "June";
                            break;
                        case 7:
                            month = "July";
                            break;
                        case 8:
                            month = "August";
                            break;
                        case 9:
                            month = "September";
                            break;
                        case 10:
                            month = "October";
                            break;
                        case 11:
                            month = "November";
                            break;
                        case 12:
                            month = "December";
                            break;
                        default:
                            month = "Not a month";
                            break;
                    }

                    Console.WriteLine("The number input corresponds to the month of: " + month);
                }
                else
                {
                    Console.WriteLine(input + " isn't a month.");
                }
                CheckMonth(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Your input is not a number.");
                CheckMonth(Console.ReadLine());
            }
        }
    }
}