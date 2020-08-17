using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    public class Exercise6
    {
        public static void BallotBox()
        {
            var candidates = new (string name, int votes)[2];
            int option = 0;
            Console.WriteLine("Wellcome to the Ballot box system. \n");
            while (true)
            {
                Console.WriteLine("Select: 1)Register a candidate / 2)Vote / 3)Count votes: ");
                var inputOption = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        option = Int32.Parse(inputOption);
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!! Try again!");
                    }
                }

                if (!(option == 1 || option == 2 || option == 3))
                {
                    Console.WriteLine("Please press the right option!\n");
                    continue;
                }
                if (option == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Please, digit the password: ");
                        string password = Console.ReadLine();
                        if (password == "Pa$$w0rd")
                        {
                            for (int i = 0; i < candidates.Length; i++)
                            {
                                Console.WriteLine("Insert the {0}candidate's name: ", i);
                                candidates[i].name = Console.ReadLine();
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password isn't correct!\n");
                            continue;
                        }
                    }
                }
                else if (option == 2)
                {
                    var match = 0;
                    foreach (var item in candidates)
                    {
                        match = (item.name == null) ? match += 1 : match;
                    }
                    if (match == candidates.Length)
                    {
                        Console.WriteLine("Please, register the candidates first!!\n");
                        continue;
                    }
                    while (true)
                    {
                        for (int i = 0; i < candidates.Length; i++)
                        {
                            Console.WriteLine($"Press {i + 1} to vote in {candidates[0].name}");
                        }
                        Console.WriteLine("Press q to quit.\n");
                        var optionVote = Console.ReadLine();
                        if (optionVote == "q")
                            break;

                        for (int i = 0; i < candidates.Length; i++)
                        {
                            if (Int32.Parse(optionVote) == (i + 1))
                            {
                                candidates[i].votes++;
                            }
                        }

                    }
                }
                else if (option == 3)
                {
                    var winner = candidates[0];
                    var isDraw = false;
                    var drawCandidates = winner.name;

                    for (int i = 1; i < candidates.Length; i++)
                    {
                        var currentCandidate = candidates[i];

                        if (currentCandidate.votes > winner.votes)
                        {
                            winner = currentCandidate;
                            drawCandidates = currentCandidate.name;
                        }
                        else if (currentCandidate.votes == winner.votes)
                        {
                            isDraw = true;
                            drawCandidates += $", {currentCandidate.name}";
                        }
                    }

                    if (isDraw)
                    {
                        System.Console.WriteLine($"Second turn among: {drawCandidates}!");
                    }
                    else
                    {
                        System.Console.WriteLine($"The winner is: {winner.name}");
                        System.Console.WriteLine($"wiht : {winner.votes} votos!");
                    }
                }
            }
        }

    }
}
