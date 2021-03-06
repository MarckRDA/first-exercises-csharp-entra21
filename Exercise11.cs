using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise11
    {
        public static void Division()
        {
            var numberOne = 0.0;
            var numberTwo = 0.0;

            Console.WriteLine("Digit a number: ");
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
            Console.WriteLine("Digit another number: ");
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
            var answer = (numberTwo == 0.0) ? "Division by 0 doesn't exist!" : $"Result = {numberOne / numberTwo}";
            Console.WriteLine(answer);

        }

    }
}
