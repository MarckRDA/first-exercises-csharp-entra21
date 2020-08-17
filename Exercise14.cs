using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise14
    {
        public static void NumbersSorted()
        {
            var numberA = 0.0;
            var numberB = 0.0;
            var numberC = 0.0;
            var temp = 0.0;
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberA = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }

            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberB = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }

            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberC = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }


            if (numberA > numberB && numberA > numberC)
            {
                temp = numberC;
                numberC = numberA;
                numberA = temp;
            }
            if (numberB > numberA && numberB > numberC)
            {
                temp = numberC;
                numberC = numberB;
                numberB = temp;
            }
            if (numberA > numberB)
            {
                temp = numberB;
                numberB = numberA;
                numberA = temp;
            }
            Console.WriteLine(numberA);
            Console.WriteLine(numberB);
            Console.WriteLine(numberC);
        }

    }
}
