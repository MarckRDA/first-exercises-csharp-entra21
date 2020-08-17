using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise8
    {
        public static void XMutipleY()
        {
            var numberOne = 0.0;
            var numberTwo = 0.0;
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberOne = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }
            System.Console.WriteLine("Digit another number: ");
            while (true)
            {
                try
                {
                    numberTwo = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }
            var answer = (numberOne % numberTwo == 0) ? $"{numberOne} is a multiple of {numberTwo}" : $"{numberOne} is not a multiple of {numberTwo}";
            Console.WriteLine(answer);
        }

    }
}
