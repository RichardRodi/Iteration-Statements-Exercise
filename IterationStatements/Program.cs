using System;

namespace IterationStatements
{

    public class Program


    {

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print3To999()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method to accept two integers as parameters and check whether they are equal or not
        public static void IsEqual(int a, int b)
        {

            if (a == b)
            {
                Console.WriteLine("They are Equal\n");
            } 
            else if (b != a) 
            {
                Console.WriteLine("They are not Equal\n");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void IsEvenOrOdd(int c)
        {
            if (c % 2 == 0)
            {
                Console.WriteLine("Its Even\n");
            }
            else
            {
                Console.WriteLine("Its Odd\n");
            }




        }
        //Write a method to check whether a given number is positive or negative
            public static void IsPositiveOrNegative(int e)
        {
            if (e == 0)
            {
                Console.WriteLine($"{e} is Zero\n");

            }
            else if (e < 0)
            {
                Console.WriteLine($"{e} is Negative\n");

            }
            else if (e > 0)
            {
                Console.WriteLine($"{e} is Positive\n");
            }

        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void AgeChecker(int f)
        {
            if (f >= 18)
                {
                Console.WriteLine("You are old enough to vote"); 
                }
            else 
            {
                Console.WriteLine("You are not old enough to vote");
                    
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {


            Print1000();

            Print3To999();

            Console.WriteLine($"Are these two numbers equal to eachother? Enter Two Numbers:");
            var answer1 = Int32.Parse(Console.ReadLine());
            var answer2 = Int32.Parse(Console.ReadLine());
            IsEqual(answer1, answer2);

            Console.WriteLine($"Is your number odd or even? Enter Number:");
            var answer3 = Int32.Parse(Console.ReadLine());
            IsEvenOrOdd (answer3);
          
            Console.WriteLine("Is your number a positve or negative number. Enter Number:");
            var answer4 =  Int32.Parse( Console.ReadLine() );
            IsPositiveOrNegative(answer4);

            Console.WriteLine("Check if your old enough to vote. Enter Your Age:");
            var answer5 = Int32.Parse(Console.ReadLine());
            AgeChecker(answer5);





        }
    }
}
