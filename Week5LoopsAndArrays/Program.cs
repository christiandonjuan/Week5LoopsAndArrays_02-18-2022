using System;

namespace Week5_LoopsAndArrays
{
    class Program
    {
        static void Main(String[] args)
        {
            ProblemOne();
            Console.WriteLine("\n\n-------------------------------------------------------");
            ProblemTwo();
            Console.WriteLine("\n\n-------------------------------------------------------");
            ProblemThree();
            Console.WriteLine("\n\n-------------------------------------------------------");
            ProblemFour();
            Console.WriteLine("\n\n-------------------------------------------------------");
            ProblemFive();
        }

        //1.
        static void ProblemOne()
        {
            Console.WriteLine("PROBLEM 1.\n");
            int numCounter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    ++numCounter;
                }
            }

            Console.WriteLine("Count of numbers 1-100\nthat are divisble by 3: " + numCounter);
        }

        //2.
        static void ProblemTwo()
        {
            Console.WriteLine("\n\nPROBLEM 2.\n");
            Console.WriteLine("Please enter a number or \"ok\" to exit: ");
            string userEntered = Console.ReadLine();
            int sum = 0;
            int numCounter = 0;

            while (userEntered != "ok")
            {
                ++numCounter;
                int currentNum = int.Parse(userEntered);
                sum += currentNum;
                Console.WriteLine("Please enter a number or \"ok\" to exit: ");
                userEntered = Console.ReadLine();
            }
            if (numCounter != 0)
            {
                Console.WriteLine("\nSum of all numbers entered: " + sum);
            }
            Console.WriteLine("Thank you.");
        }

        //3.
        static void ProblemThree()
        {
            Console.WriteLine("\n\nPROBLEM 3.\n");
            Console.WriteLine("Please enter a number to find the factorial of: ");
            string userEntered = Console.ReadLine();
            int num = int.Parse(userEntered);

            int factorial = num;
            for (int i = num - 1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("\n" + num + "! = " + factorial);
        }

        //4.
        public static Random random; //Used to make random number in ProblemFour
        static void ProblemFour()
        {
            Console.WriteLine("\n\nPROBLEM 4.\n");
            random = new Random();
            int rNum = random.Next(1, 10);
            Console.WriteLine("Random Number: " + rNum + "\nYou have 4 chances to guess.\n\n");

            for (int i = 4; i > 0; i--)
            {
                if (i > 1) //if there's more than 1 guess left output the word guesses, otherwise output the word guess
                {
                    Console.WriteLine("Guess the number (You have " + i + " guesses left): ");
                }
                else
                {
                    Console.WriteLine("Guess the number (You have " + i + " guess left): ");
                }
                //Input their guess into a string and Parse it to an integer each iteration
                string guess = Console.ReadLine();
                int guessNum = int.Parse(guess);

                if (guessNum == rNum)
                {
                    Console.WriteLine("\nYou won! " + guessNum + " is correct!");
                    break; //exit loop if a guess is correct
                }
                else
                {
                    if (i > 1) //if there's more than 1 guess left prompt user to try again, otherwise output they lost and reveal the random number
                    {
                        Console.WriteLine("Sorry " + guessNum + " isn't correct, please try again.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nYou lost! The random number is " + rNum);
                    }   
                }
            }
        }

        //5.
        static void ProblemFive()
        {
            Console.WriteLine("\n\nPROBLEM 5.\n");
            Console.WriteLine("Please enter a series of numbers separated by comma(,) no spaces: ");
            string userEntered = Console.ReadLine();

            //Initialize string Nums array to the user input using .Split()
            //and declare integer Nums array to the Length of string Nums
            string[] sNums = userEntered.Split(',');
            int[] iNums = new int[sNums.Length];

            for (int i = 0; i < sNums.Length; i++)
            {
                iNums[i] = int.Parse(sNums[i]); //Initialize interger Nums to the content of string Nums converted to integer type
            }

            int maxNum = iNums[0]; //initialize the maximum number to start off as integer Nums index of 0
            for (int i = 1; i < iNums.Length; i++) //i starts at 1 because maxNum's initial value doesn't need to be compared to itself
            {
                if (iNums[i] > maxNum)
                {
                    maxNum = iNums[i];
                }
            }
            Console.WriteLine("\nMaximum of the numbers entered: " + maxNum);       
        }
    }
}
