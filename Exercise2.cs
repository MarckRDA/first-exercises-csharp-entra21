using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise2
    {
        public static void SumBetween1and100()
        {
            var sum = 0;
            for (int count = 0; count < 101; count++)
            {
                sum += count;
            }
            Console.WriteLine($"The sum of numbers between 1 and 100 is:{sum}");
        }
    }
}
