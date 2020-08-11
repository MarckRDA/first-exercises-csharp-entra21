using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace first_C__exercises_entra21
{
    class Program
    {
        static void Exercise1a()
        {
            for (int count = 1; count < 11; count++)
            {
                Console.WriteLine(count);
            }
            
        }

        static void Exercise1b()
        {
            for(int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }
        }

        
        static void Exercise1c()
        {
            for (int count = 2; count < 11; count+=2)
            {
                Console.WriteLine(count);
            }
        }

        static void Exercise2()
        {
            var sum = 0;
            for (int count = 0; count < 101; count++)
            {
                sum += count;
            }
            Console.WriteLine($"The sum of numbers between 1 and 100 is:{sum}");
        }

        
        static void Exercise3()
        {
           for (int count = 1; count < 200; count+=2)
           {
               Console.WriteLine(count);
           }
        }

        static void Exercise4()
        {
            var age = 0.0;
            var average = 0.0;
            var counter = 0.0;
            while(true){
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
                        Console.WriteLine("Insert only numbers!");    
                    }    
                }
                
                
                if(age == 0.0){
                    break;
                }
                average += age;
                counter++;    
            }
            Console.WriteLine($"The average of ages is: {average/counter}");
        }

        static void Exercise5()
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
                        Console.WriteLine("Insert only numbers!!");
                    }    
                }
                percents = (womensAge > 17 && womensAge < 36) ? percents+=1 : percents;                   
                
            }
            System.Console.WriteLine($"The percent of women's age between 18 and 35: {String.Format("{0:0.0}",(percents/numberWomen)*100)}%");
        }

        static void Exercise6()
        {
            var candidates = new (string name, int votes)[2];
            int option = 0;
            Console.WriteLine("Wellcome to the Ballot box system. \n");
            while(true){
                Console.WriteLine("Select: 1)Register a candidate / 2)Vote / 3)Count votes: ");
                var inputOption =Console.ReadLine();
                while (true)
                {
                    try
                    {
                        option = Int32.Parse(inputOption);
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!!");
                    }    
                }
                
                if(!(option == 1 || option == 2 || option == 3)){
                    Console.WriteLine("Please press the right option!\n");
                    continue;
                }
                if(option == 1){
                    while(true){
                        Console.WriteLine("Please, digit the password: ");
                        string password = Console.ReadLine();
                        if(password == "Pa$$w0rd"){
                            for (int i = 0; i < candidates.Length; i++)
                            {
                                Console.WriteLine("Insert the {0}candidate's name: ", i);
                                candidates[i].name = Console.ReadLine();
                            }
                            break;
                        }
                        else{
                            Console.WriteLine("Password isn't correct!\n");
                            continue;
                        }
                    }
                }
                else if(option == 2){
                    var match = 0;
                    foreach (var item in candidates)
                    {
                        match = (item.name == null) ? match+=1 : match;
                    }
                    if(match == candidates.Length){
                        Console.WriteLine("Please, register the candidates first!!\n");
                        continue;
                    }
                    while(true){
                        for (int i = 0; i < candidates.Length; i++)
                        {
                            Console.WriteLine($"Press {i + 1} to vote in {candidates[0].name}");    
                        }
                        Console.WriteLine("Press q to quit.\n");
                        var optionVote = Console.ReadLine();
                        if(optionVote == "q")
                            break;
                        
                        for (int i = 0; i < candidates.Length; i++)
                        {
                            if(Int32.Parse(optionVote) == (i+1))
                            {
                                candidates[i].votes++;
                            }
                        }
                        
                    }
                }
                else if(option == 3){
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

        static void Exercise7()
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
                    Console.WriteLine("Insert only numbers!!");
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
                    Console.WriteLine("Insert only numbers!!");
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
                    Console.WriteLine("Insert only numbers!!");
                }    
            }
            
            System.Console.WriteLine($"You've lost R${String.Format("{0:0.00}",(365*years)*cigarettesPerDay*(cigarettesPrice/20))}");
                    
        }

        static void Exercise8()
        {
            var numberOne = 0.0;
            var numberTwo = 0.0;
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberOne = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }
            }
            System.Console.WriteLine("Digit another number: ");
            while (true)
            {
                try
                {
                    numberTwo = double.Parse(input2);
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }
            }
            var answer = (numberOne % numberTwo == 0) ?  $"{numberOne} is a multiple of {numberTwo}" : $"{numberOne} is not a multiple of {numberTwo}";
            Console.WriteLine(answer);
        }

        static void Exercise9()
        {
            double [] numbers = new double[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digit the {0}º number: ", i+1);
                while (true)
                {
                    try
                    {
                        numbers[i] = Double.Parse(Console.ReadLine());    
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!!");
                    }
                }           
            }
            var answer = (numbers[0] > numbers[1] + numbers[2]) ? $"{numbers[0]} is bigger than the sum between {numbers[1]} and {numbers[2]}" :  $"{numbers[0]} is lower than the sum between {numbers[1]} and {numbers[2]}";
            Console.WriteLine(answer);
            
        }    

        static void Exercise10()
        {
            var numberOne = 0.0;
            var numberTwo = 0.0;
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberOne = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }    
            }
            System.Console.WriteLine("Digit another number: ");
            while (true)
            {
                try
                {
                    numberTwo = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }
            }
                    
            if(numberOne > numberTwo){
                Console.WriteLine($"{numberOne} is bigger than {numberTwo}");
            }
            else if(numberTwo > numberOne){
                Console.WriteLine($"{numberTwo} is bigger than {numberOne}");
            }
            else{
                Console.WriteLine($"{numberTwo} == {numberOne}");
            }
            
        }                

        static void Exercise12()
        {
            var numberOne = 0.0;
            var numberTwo = 0.0;
            
            Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberOne = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }    
            }
            Console.WriteLine("Digit another number: ");
            while (true)
            {
                try
                {
                    numberTwo = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }    
            }
            var answer = (numberTwo == 0.0) ? "Division by 0 doesn't exist!" : $"Result = {numberOne/numberTwo}"; 
            Console.WriteLine(answer);
            
        }

        static void Exercise13()
        {
            double [] numbers = new double[10];
            var match = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Digit a number: ");
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

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                    match = (numbers[i] > numbers[j]) ? match+=1 : match;
                             
                if (match == numbers.Length-1)
                {
                    System.Console.WriteLine($"The bigest number amoung those 10 is: {numbers[i]}");
                    break;        
                }
                
                match = 0;
            }
            
        }

        static void Exercise14()
        {
            var numberA = 0.0;
            var numberB = 0.0;
            var numberC = 0.0;
            var temp = 0.0;
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberA = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }
            }
            
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberB = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }    
            }
            
            System.Console.WriteLine("Digit a number: ");
            while (true)
            {
                try
                {
                    numberC = Double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }    
            }
            
            
            if (numberA > numberB && numberA > numberC)
            {
                temp = numberC;
                numberC = numberA;
                numberA = temp;
            }
            if (numberB > numberA && numberB > numberC)
            {
                temp = numberC;
                numberC = numberB;
                numberB = temp;
            }
            if (numberA > numberB)
            {
                temp = numberB;
                numberB = numberA;
                numberA = temp;
            }
            Console.WriteLine(numberA);
            Console.WriteLine(numberB);
            Console.WriteLine(numberC);
        }

        static void Exercise15()
        {
            const int counter = 10;
            var multipleBy3 = 0; 
            var multipleBy5 = 0;

            for (int i = 0; i < counter; i++)
            {   
                var number = 0.0;
                Console.WriteLine("Digit a number: ");
                while (true)
                {
                    try
                    {
                        number = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Insert only numbers!!");
                    }    
                }
                
                if(number % 3 == 0){
                    multipleBy3++;
                }
                if(number % 5 == 0){
                    multipleBy5++;
                }
            }
            System.Console.WriteLine($"There's {multipleBy3} numbers multiple by 3 and {multipleBy5} numbers multiple by 5");
            
        }

        static void Exercise16()
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
                    Console.WriteLine("Insert only number!!");
                }   
            }          
                        
            if(netSalary < 600.00){
                System.Console.WriteLine($"Net Salary: R$ {netSalary}");
            }
            else if(netSalary > 600.00 && netSalary <= 1000.00){
                System.Console.WriteLine($"Net Salary: R$ {netSalary - (netSalary*0.2)}");
            }
            else if(netSalary > 1200.00 && netSalary <= 2000.00){
                System.Console.WriteLine($"Net Salary: R$ {netSalary - (netSalary*0.25)}");
            }
            else{
                System.Console.WriteLine($"Net Salary: R$ {netSalary - (netSalary*0.3)}");
            }
        }
        static void Exercise17()
        {
            var number = 0.0;
            Console.WriteLine("Digit a number: Press -1 to quit.");
            while (true)
            {
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    break;    
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only number!!");
                }
            }
            
            Console.WriteLine("========================");
            Console.WriteLine(" Mutiplication table ");
            Console.WriteLine("========================");
                
            for (int count = 0; count < 11; count++)
            {
                if(number == -1){
                    break;
                }
                Console.WriteLine($" {number} X {count} = {number*count}");
                
            }
        }

        static void Exercise18()
        {
            var qtdApples = 0.0;
            System.Console.WriteLine("How many apples would you like buying? ");
            while (true)
            {
                try
                {
                    qtdApples = Double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Insert only numbers!!");
                }
            }
            var answer = (qtdApples < 6.00) ? $"Purchase: R$ {String.Format("{0:0.00}",qtdApples*1.30)}" : $"Purchase: R$ {String.Format("{0:0.00}", qtdApples*1.00)}";  
            Console.WriteLine(answer);
        }
        static void Main(string[] args)
        {
            Exercise13();
        }
    }
}
