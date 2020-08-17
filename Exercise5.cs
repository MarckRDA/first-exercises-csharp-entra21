using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise5
    {
        public static void womensAgeBetween18and35()
        {
            var womensAge = 0.0;
            const double numberWomen = 5.0;
            var percents = 0.0;

            for (double count = 0; count < numberWomen; count++)
            {
                System.Console.WriteLine("Digit the woman's name: ");
                Console.ReadLine();
                System.Console.WriteLine("Digit the woman's age: ");
                while (true)
                {
                    try
                    {
                        womensAge = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }
                percents = (womensAge > 17 && womensAge < 36) ? percents += 1 : percents;

            }
            System.Console.WriteLine($"The percent of women's age between 18 and 35: {String.Format("{0:0.0}", (percents / numberWomen) * 100)}%");
        }

    }
}
