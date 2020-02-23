using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMAssignment2
{
    class Program
    {
        // method to display the main menu
        static void DisplayMenu()
        {
            // show all the menu options
            Console.WriteLine("1. Enter triangle numbers ");
            Console.WriteLine("2. Exit ");
        }

        static bool IsValidUserChoice(string choice)
        {
            if (choice.Length != 1)
                return false;

            return (choice[0] == '1' || choice[0] == '2');
        }

        static void Main(string[] args)
        {

            // the circle object
            TriangleAnalyzer triangle = new TriangleAnalyzer();


            //after we have our starting radius
            string userChoice = " ";

            while (userChoice[0] != '2')
            {
                DisplayMenu();

                Console.Write("Enter a choice and then press ENTER: ");

                userChoice = Console.ReadLine();

                while (!IsValidUserChoice(userChoice))
                {
                    Console.WriteLine("Invalid choice!");
                    Console.WriteLine();

                    DisplayMenu();

                    Console.Write("Enter a choice: ");

                    userChoice = Console.ReadLine();
                }


                //start building our triangle numbers
                int numberOne = 0;
                int numberTwo = 0;
                int numberThree = 0;

                if (userChoice[0] == '1')
                {

                //number 1
                Start:
                    Console.Write("Please enter the first number: ");
                    string input = Console.ReadLine();
                    try
                    {
                        int result = Int32.Parse(input);
                        numberOne = (result);
                        triangle.SetNumberOne(result);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to parse '{input}', please try again.");
                        goto Start;
                    }

                //number 2
                StartTwo:
                    Console.Write("Please enter the second number: ");
                    string inputTwo = Console.ReadLine();
                    try
                    {
                        int result = Int32.Parse(inputTwo);
                        numberTwo = (result);
                        triangle.SetNumberTwo(result);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to parse '{inputTwo}', please try again.");
                        goto StartTwo;
                    }

                //number 3
                StartThree:
                    Console.Write("Please enter the third number: ");
                    string inputThree = Console.ReadLine();
                    try
                    {
                        int result = Int32.Parse(inputThree);
                        numberThree = (result);
                        triangle.SetNumberThree(result);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Unable to parse '{inputThree}', please try again.");
                        goto StartThree;
                    }

                    //call our Anaylize method to display triangle information
                    triangle.Analyize();

                }

                //Exit program
                else if (userChoice[0] == '2')
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();
            }
        }
    }
}