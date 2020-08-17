using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise9
    {
       public static void FirstGreatterThanSumBetweenLastBoth()
        {
            double[] numbers = new double[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digit the {0}º number: ", i + 1);
                while (true)
                {
                    try
                    {
                        numbers[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
            }
            var answer = (numbers[0] > numbers[1] + numbers[2]) ? $"{numbers[0]} is bigger than the sum between {numbers[1]} and {numbers[2]}" : $"{numbers[0]} is lower than the sum between {numbers[1]} and {numbers[2]}";
            Console.WriteLine(answer);

        }

    }
}
