    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge102
{
    class Program
    {
        static bool firstTime = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name here:");
            ReverseName(Console.ReadLine());
        }

        static void ReverseName(string name)
        {
        
                string[] brokenName = name.Split(' ');
                Console.WriteLine("If we rearrange it slightly, we'll get: " + brokenName[1] + ", " + brokenName[0]);
                Console.WriteLine("Write a new name:");

            if (!firstTime)
            {
                Console.WriteLine("Please exit the application manually if you desire to quit.");
            }

            ReverseName(Console.ReadLine());
        }
    }
}
