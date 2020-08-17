using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise16
    {
        public static void NetSalary()
        {
            double netSalary = 0.0;
            System.Console.WriteLine("Please digit your salary: ");

            while (true)
            {
                try
                {
                    netSalary = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only number!! Try again!");
                }
            }

            if (netSalary <= 600.00)
            {
                System.Console.WriteLine($"Net Salary: R$ {netSalary}");
            }
            else if (netSalary <= 1200.00)
            {
                System.Console.WriteLine($"Net Salary: R$ {netSalary - (netSalary * 0.2)}");
            }
            else if (netSalary <= 2000.00)
            {
                System.Console.WriteLine($"Net Salary: R$ {netSalary - (netSalary * 0.25)}");
            }
            else
            {
                System.Console.WriteLine($"Net Salary: R$ {netSalary - (netSalary * 0.3)}");
            }
        }
    }
}
