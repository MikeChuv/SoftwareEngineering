using System;
using System.Numerics;

using UtilityLibraries;

namespace Demonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Your complex:");
                string input = Console.ReadLine();
                string[] subs = input.Split(' ');

                Complex c1 = new Complex(Convert.ToDouble(subs[0]), Convert.ToDouble(subs[1]));

                if (c1.IsReal()) Console.WriteLine("Real number");
                else Console.WriteLine("Complex number");

                if (c1.IsImaginary()) Console.WriteLine("Only Imaginary");

                Console.Write("Continue? [y/n] ");
                input = Console.ReadLine();
                Console.WriteLine(input);
                if (input != "y") flag = false;
            }
        }
    }
}
