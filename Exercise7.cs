using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise7
    {
        public static void SpentMoneyWithCigarrets()
        {
            var cigarettesPerDay = 0.0;
            var cigarettesPrice = 0.0;
            var years = 0.0;

            System.Console.WriteLine("How many years have you been smoking cigarettes? ");
            while (true)
            {
                try
                {
                    years = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }
            System.Console.WriteLine("And how many cigarettes per day? ");
            while (true)
            {
                try
                {
                    cigarettesPerDay = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }
            System.Console.WriteLine("how much does it cost?");
            while (true)
            {
                try
                {
                    cigarettesPrice = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }

            System.Console.WriteLine($"You've lost R${String.Format("{0:0.00}", (365 * years) * cigarettesPerDay * (cigarettesPrice / 20))}");

        }

    }
}
