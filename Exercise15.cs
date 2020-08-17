using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise15
    {
        public static void Multipleby3and5()
        {
            const int counter = 10;
            var multipleBy3 = 0;
            var multipleBy5 = 0;

            for (int i = 0; i < counter; i++)
            {
                var number = 0.0;
                Console.WriteLine("Digit a number: ");
                while (true)
                {
                    try
                    {
                        number = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }

                if (number % 3 == 0)
                {
                    multipleBy3++;
                }
                if (number % 5 == 0)
                {
                    multipleBy5++;
                }
            }
            System.Console.WriteLine($"There's {multipleBy3} numbers multiple by 3 and {multipleBy5} numbers multiple by 5");

        }

    }
}
