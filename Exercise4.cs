using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise4
    {
        public static void AgeAverage()
        {
            var age = 0.0;
            var average = 0.0;
            var counter = 0.0;
            while (true)
            {
                Console.WriteLine("Digit an age: ");
                while (true)
                {
                    try
                    {
                        age = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }


                if (age == 0.0)
                {
                    break;
                }
                average += age;
                counter++;
            }
            Console.WriteLine($"The average of ages is: {average / counter}");
        }

    }
}
