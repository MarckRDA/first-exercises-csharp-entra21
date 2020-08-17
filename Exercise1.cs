using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise1
    {
        public static void Exercise1a()
        {
            for (int count = 1; count < 11; count++)
            {
                Console.WriteLine(count);
            }

        }

        public static void Exercise1b()
        {
            for (int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }
        }


        public static void Exercise1c()
        {
            for (int count = 2; count < 11; count += 2)
            {
                Console.WriteLine(count);
            }
        }

    }
}
