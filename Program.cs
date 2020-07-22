using System;
using System.Collections.Generic;

namespace first_C__exercises_entra21
{
    class Program
    {
        //Exercise 1)a
        static void IncreasingNumbers(string[] args)
        {
            var counter = 1;
            while(counter <= 10){
                System.Console.WriteLine(counter);
                counter++;
            }
        }

        //Exercise 1)b
        static void DecreasingNumbers(string[] args)
        {
            var counter = 10;
            while(counter >= 1){
                System.Console.WriteLine(counter);
                counter--;
            }
        }

        //Exercise 1)c
        static void PairNumbers(string[] args)
        {
            var counter = 1;
            while(counter <= 10){
                if(counter % 2 == 0){
                    System.Console.WriteLine(counter);
                }
                counter++;
            }
        }

        //Exercise 2
        static void SumBetween1and100(string[] args)
        {
            var counter = 1;
            var sum = 0;
            while(counter <= 100){
                sum += counter;
                counter++;
            }
            System.Console.WriteLine($"The sum of numbers between 1 and 100 is:{sum}");
        }

        //Exercise 3
        static void PrintNumbersLowThan200(string[] args)
        {
            var counter = 1;
            while(counter < 200){
                if(counter % 2 != 0){
                    System.Console.WriteLine(counter);
                }
                counter++;
            }
        }

        //Exercise 4
        static void AverageAges(string[] args)
        {
            double age;
            double average = 0.0;
            var counter = 0.0;
            while(true){
                System.Console.WriteLine("Digit an age: ");
                age = double.Parse(System.Console.ReadLine());
                if(age == 0.0){
                    break;
                }
                average += age;
                counter++;    
            }
            System.Console.WriteLine($"The average of ages is: {average/counter}");
        }

        //Excercise 5
        static void PercentWomensAge(string[] args)
        {
            var womensName = "";
            double womensAge;
            double percents = 0.0;
            var counter = 0.0;
            while(counter < 5){
                System.Console.WriteLine("Digit the woman's name: ");
                womensName = System.Console.ReadLine();
                System.Console.WriteLine("Digit the woman's age: ");
                womensAge = double.Parse(System.Console.ReadLine());
                if(womensAge >= 18 && womensAge <= 35){
                    percents++;
                }                   
                counter++; 
            }
            System.Console.WriteLine($"The percent of women's age between 18 and 35: {String.Format("{0:0.0}",(percents/counter)*100)}%");
        }

        //Exercise 6
        static void BallotBox(string[] args)
        {
            var candidates = new string[2];
            var candidate1Vote = 0;
            var candidate2Vote = 0;
            System.Console.WriteLine("Wellcome to the Ballot box system. \n");
            while(true){
                System.Console.WriteLine("Select: 1)Register a candidate / 2)Vote / 3)Count votes: ");
                int option = Int32.Parse(System.Console.ReadLine());
                if(!(option == 1 || option == 2 || option == 3)){
                    System.Console.WriteLine("Please press the right option!\n");
                    continue;
                }
                if(option == 1){
                    while(true){
                        System.Console.WriteLine("Please, digit the password: ");
                        string password = System.Console.ReadLine();
                        if(password == "Pa$$w0rd"){
                            var index = 0;
                            while(index < 2){
                                System.Console.WriteLine("Insert the candidate's name: ");
                                candidates[index] = System.Console.ReadLine();
                                index++;
                            }
                            break;
                        }
                        else{
                            System.Console.WriteLine("Password isn't correct!\n");
                            continue;
                        }
                    }
                }
                else if(option == 2){
                    if(candidates[0] == null && candidates[1]== null){
                        System.Console.WriteLine("Please, register the candidates first!!\n");
                        continue;
                    }
                    while(true){
                        System.Console.WriteLine($"Press 1 to vote in {candidates[0]} or 2 to vote in {candidates[1]}. Press q to quit.\n");
                        var optionVote = System.Console.ReadLine();
                        if(optionVote == "1"){
                            candidate1Vote++;
                        }
                        else if(optionVote == "2"){
                            candidate2Vote++;
                        }
                        else if(optionVote == "q"){
                            break;
                        }
                        else{
                            System.Console.WriteLine("Please, select the right option!\n");
                            continue;
                        }
                    }
                }
                else if(option == 3){
                    if((candidates[0] == null && candidates[1]== null) || (candidate1Vote == 0) && (candidate2Vote==0)){
                        System.Console.WriteLine("Please, you need to put a candidate in the system or start a votation\n");
                        continue;
                    }
                    if(candidate1Vote > candidate2Vote){
                        System.Console.WriteLine($"{candidates[0]} won!!!");
                        break;
                    }
                    else if(candidate2Vote > candidate1Vote){
                        System.Console.WriteLine($"{candidates[1]} won!!!");
                        break;
                    }
                    else{
                        System.Console.WriteLine("Second turn!!!");
                        break;
                    }
                }
            }    
        }

        //Exercise 7
        static void CigarettesPriceYear(string[] args)
        {
            double cigarettesPerDay;
            double cigarettesPrice;
            double years;
                       
            System.Console.WriteLine("How many years have you been smoking cigarettes? ");
            years = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("And how many cigarettes per day? ");
            cigarettesPerDay = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("how much does it cost?");
            cigarettesPrice = double.Parse(System.Console.ReadLine());
            
            System.Console.WriteLine($"You've lost R${String.Format("{0:0.00}",(365*years)*cigarettesPerDay*(cigarettesPrice/20))}");
                    
        }

        //Exercise 8
        static void MultipleNumbers(string[] args)
        {
            System.Console.WriteLine("Digit a number: ");
            var numberOne = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Digit another number: ");
            var numberTwo = double.Parse(System.Console.ReadLine());

            if(numberOne % numberTwo == 0){
                System.Console.WriteLine($"{numberOne} is a multiple of {numberTwo}");
            }
            else{
                System.Console.WriteLine($"{numberOne} is not a multiple of {numberTwo}");
            }
        }

        //Excercise 9
        static void FirstNumberbiggerthanLastTwo(string[] args)
        {
            System.Console.WriteLine("Digit a number: ");
            var numberOne = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Digit another number: ");
            var numberTwo = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Digit the last: ");
            var numberThree = Int32.Parse(System.Console.ReadLine());

            if(numberOne > numberTwo + numberThree){
                System.Console.WriteLine($"{numberOne} is bigger than the sum between {numberTwo} and {numberThree}");
            }
            else{
                System.Console.WriteLine($"{numberOne} is lower than the sum between {numberTwo} and {numberThree}");
            }
            
        }    

        //Exercise 10
        static void ABiggerThanB(string[] args)
        {
            System.Console.WriteLine("Digit a number: ");
            var numberOne = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Digit another number: ");
            var numberTwo = Int32.Parse(System.Console.ReadLine());
            
            if(numberOne > numberTwo){
                System.Console.WriteLine($"{numberOne} is bigger than {numberTwo}");
            }
            else if(numberTwo > numberOne){
                System.Console.WriteLine($"{numberTwo} is bigger than {numberOne}");
            }
            else{
                System.Console.WriteLine($"{numberTwo} == {numberOne}");
            }
            
        }                

        //Exercise 11
        static void DivisionByZero(string[] args)
        {
            System.Console.WriteLine("Digit a number: ");
            var numberOne = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Digit another number: ");
            var numberTwo = double.Parse(System.Console.ReadLine());
            
            if(numberTwo == 0.0){
                System.Console.WriteLine("Division by 0 doesn't exist!");
            }
            else{
                System.Console.WriteLine($"Result = {numberOne/numberTwo}");
            }
            
        }

        // Exercise 13
        static void TheBiggestNumber(string[] args)
        {
            var numbers = new List<int>();
            int counter = 0;

            while(counter < 10){
                System.Console.WriteLine("Digit a number: ");
                numbers.Add(Int32.Parse(System.Console.ReadLine()));
                counter++;
            }
            numbers.Sort();
            System.Console.WriteLine($"The bigest number amoung those 10 is: {numbers.ToArray()[9]}");
        }

        //Excercise 14
        static void SortNumbers(string[] args)
        {
            var numbers = new List<int>();
            int counter = 0;

            while(counter < 3){
                System.Console.WriteLine("Digit a number: ");
                numbers.Add(Int32.Parse(System.Console.ReadLine()));
                counter++;
            }
            numbers.Sort();
            counter = 0;
            while(counter < 3){
                System.Console.WriteLine("\n" + numbers.ToArray()[counter]);
                counter++;
            }
        }

        //Exercise 15
        static void MultiplesBy3And5(string[] args)
        {
            var counter = 0;
            var multipleBy3 = 0; 
            var multipleBy5 = 0;

            while(counter < 10){
                System.Console.WriteLine("Digit a number: ");
                var number =Int32.Parse(System.Console.ReadLine());
                if(number % 3 == 0){
                    multipleBy3++;
                }
                if(number % 5 == 0){
                    multipleBy5++;
                }
                counter++;
            }
            
            System.Console.WriteLine($"There's {multipleBy3} numbers multiple by 3 and {multipleBy5} numbers multiple by 5");
            
        }

        //Exercise 16
        static void NetSalary(string[] args)
        {
            double netSalary;
            System.Console.WriteLine("Please digit your salary: ");
            netSalary = double.Parse(System.Console.ReadLine());
            
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

        //Exercise 17
        static void MutiplicationTable(string[] args)
        {
            int number;
            var counter = 0;

            System.Console.WriteLine("Digit a number: Press -1 to quit.");
            number = Int32.Parse(System.Console.ReadLine());

            System.Console.WriteLine("========================");
            System.Console.WriteLine(" Mutiplication table ");
            System.Console.WriteLine("========================");
                
            while(counter < 11){
                if(number == -1){
                    break;
                }
                System.Console.WriteLine($" {number} X {counter} = {number*counter}");
                counter++;
            }
        }

        // Exercise 18
        static void ApplesPriceCalculator(string[] args)
        {
            double qtdApples;
            System.Console.WriteLine("How many apples would you like buying? ");
            qtdApples = double.Parse(System.Console.ReadLine());
            if(qtdApples < 6.00){
                System.Console.WriteLine($"Purchase: R$ {String.Format("{0:0.00}",qtdApples*1.30)}");
            }
            else{
                System.Console.WriteLine($"Purchase: R$ {String.Format("{0:0.00}", qtdApples*1.00)}");
            }
        }

    }
}
