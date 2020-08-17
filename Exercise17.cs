using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise17
    {
        public static void MutiplicationTable()
        {
            var number = 0.0;
            Console.WriteLine("Digit a number: Press -1 to quit.");
            while (true)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only number!! Try again!");
                }
            }

            Console.WriteLine("========================");
            Console.WriteLine(" Mutiplication table ");
            Console.WriteLine("========================");

            for (int count = 0; count < 11; count++)
            {
                if (number == -1)
                {
                    break;
                }
                Console.WriteLine($" {number} X {count} = {number * count}");

            }
        }

    }
}
