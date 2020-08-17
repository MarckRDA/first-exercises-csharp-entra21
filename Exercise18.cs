using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise18
    {
        public static void ApplesPrice()
        {
            var qtdApples = 0.0;
            System.Console.WriteLine("How many apples would you like buying? ");
            while (true)
            {
                try
                {
                    qtdApples = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!! Try again!");
                }
            }
            var answer = (qtdApples < 6.00) ? $"Purchase: R$ {String.Format("{0:0.00}", qtdApples * 1.30)}" : $"Purchase: R$ {String.Format("{0:0.00}", qtdApples * 1.00)}";
            Console.WriteLine(answer);
        }

    }

}
