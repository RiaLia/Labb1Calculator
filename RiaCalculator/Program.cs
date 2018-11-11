using System;

namespace RiaCalculator
{
    class Program
    {

        int firstNumber;
        int secondNumber;
        Calculator calc = new Calculator();

        static void Main(string[] args)
        {
            new Program().Menu();
        }

        public void Menu(){
            Console.WriteLine("WELCOME TO CACULATOR - 1.0");
            Console.WriteLine("");
            Console.WriteLine("1. Add two numbers");
            Console.WriteLine("2. Multiply two numbers");
            Console.WriteLine("3. Sum the numbers between two numbers.");
            Console.WriteLine("4. Add number to memory");
            Console.WriteLine("5. Clear memory");
            Console.WriteLine("6. Print calculator contents.");
            Console.WriteLine("7. Quit");
            Console.WriteLine("");
            Console.WriteLine("CHOOSE AN OPTION:");
            var choice = Console.ReadLine();
         
            int choosen = int.Parse(choice);
            ManageOptions(choosen);
           


        }

        void ManageOptions(int choice)
        {
            switch (choice)
            {
                case 1:
                    GetInput();
                    Console.WriteLine("The total is: {0}" , calc.SumNumbers(firstNumber, secondNumber));
                    Continue();
                    Menu();
                    break;
                case 2:
                    GetInput();
                    Console.WriteLine("The total is: {0}", calc.MultiplyNumbers(firstNumber, secondNumber));
                    Continue();
                    Menu();
                    break;
                case 3:
                    GetInput();
                    Console.WriteLine("The total is: {0}", calc.SumInBetween(firstNumber, secondNumber));
                    Continue();
                    Menu();
                    break;
                case 4:
                    Console.WriteLine("");
                    Console.WriteLine("Add a number to be saved");
                    calc.NumberInMemory = int.Parse(Console.ReadLine());
                    Console.WriteLine("Successfully added {0} to memory", calc.NumberInMemory);
                    Continue();
                    Menu();
                    break;
                case 5:
                    calc.NumberInMemory = 0;
                    Console.WriteLine("Number in memory cleared.");
                    Continue();
                    Menu();
                    break;
                case 6:
                    Console.WriteLine("Number in memory is: {0}", calc.NumberInMemory);
                    Continue();
                    Menu();
                    break;
                case 7:
                    Console.WriteLine("GOOD BYE");
                    return;
                default:
                    break;
            }

        }

     

        void GetInput()
        {
            Console.WriteLine("");
            Console.WriteLine("ENTER FIRST NUMBER:");
            var first = Console.ReadLine();

            firstNumber = int.Parse(first);

            Console.WriteLine("ENTER SECOND NUMBER:");
            var second = Console.ReadLine();

            secondNumber = int.Parse(second);

        }

        void Continue()
        {
            Console.WriteLine("");
            Console.WriteLine("Press any Key to get back to the menu");
            Console.ReadLine();
        }


    }
}

