using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Escolha o exercício de 1-18 de interesse:  Pressione Ctrl + C para sair");
                var option = Console.ReadLine();

                if (option == "1")
                {
                    Exercise1.Exercise1a();
                    continue;
                }
                else if (option == "2")
                {
                    Exercise2.SumBetween1and100();
                    continue;
                }
                else if (option == "3")
                {
                    Exercise3.OddNumbersBetween1and200();
                    continue;
                }
                else if (option == "4")
                {
                    Exercise4.AgeAverage();
                    continue;
                }
                else if (option == "5")
                {
                    Exercise5.womensAgeBetween18and35();
                    continue;
                }
                else if (option == "6")
                {
                    Exercise6.BallotBox();
                    continue;
                }
                else if (option == "7")
                {
                    Exercise7.SpentMoneyWithCigarrets();
                    continue;
                }
                else if (option == "8")
                {
                    Exercise8.XMutipleY();
                    continue;
                }
                else if (option == "9")
                {
                    Exercise9.FirstGreatterThanSumBetweenLastBoth();
                    continue;
                }
                else if (option == "10")
                {
                    Exercise10.EqualityBetweenAandB();
                    continue;
                }
                else if (option == "11")
                {
                    Exercise11.Division();
                    continue;
                }
                else if (option == "12")
                {
                    Exercise12.BiggestNumber();
                    continue;
                }
                else if (option == "13")
                {
                    Exercise13.BiggestNumber();
                    continue;
                }
                else if (option == "14")
                {
                    Exercise14.NumbersSorted();
                    continue;
                }
                else if (option == "15")
                {
                    Exercise15.Multipleby3and5();
                    continue;
                }
                else if (option == "16")
                {
                    Exercise16.NetSalary();
                    continue;
                }
                else if (option == "17")
                {
                    Exercise17.MutiplicationTable();
                    continue;
                }
                else if (option == "18")
                {
                    Exercise18.ApplesPrice();
                    continue;
                }
                else
                {
                    Console.WriteLine("Escolha o número correto, por favor!");
                    continue;
                }

            }

        }
    }
}

