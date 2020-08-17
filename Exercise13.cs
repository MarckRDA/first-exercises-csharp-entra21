using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise13
    {
        public static void BiggestNumber()
        {
            var biggestNumber = Double.MinValue;
            var input = 0.0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digit a number: ");
                while (true)
                {
                    try
                    {
                        input = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }

                System.Console.WriteLine($"The bigest number amoung those 10 is: {biggestNumber}");
            }

        }

    }
}




