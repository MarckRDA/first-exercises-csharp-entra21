using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise10
    {
        public static void EqualityBetweenAandB()
        {
            var numberOne = 0.0;
            var numberTwo = 0.0;
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberOne = Double.Parse(Console.ReadLine());
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
                    numberTwo = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }

            if (numberOne > numberTwo)
            {
                Console.WriteLine($"{numberOne} is bigger than {numberTwo}");
            }
            else if (numberTwo > numberOne)
            {
                Console.WriteLine($"{numberTwo} is bigger than {numberOne}");
            }
            else
            {
                Console.WriteLine($"{numberTwo} == {numberOne}");
            }

        }


    }
}
