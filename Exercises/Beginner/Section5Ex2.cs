using System;

namespace Section5Ex2
{
    class Program
    {
        /* 
       
        */
        static void mission1()
        {
            int minValue = 1;
            int maxValue = 100;
            int count = 0;

            for (int i = minValue; i <= maxValue; i++) 
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total count divisable by 3 and with no remainder: " + count);
        }

        static void mission2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or press ok to quit");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                {
                    break;
                }
                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("All entered numbers added toger is: " + sum);
        }

        //static void mission3() //Get factorial of input number
        //{
        //    Console.WriteLine("Enter a number to find the factorial for");
        //    int factorial = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < factorial; i++) 
        //    {
        //        factorial = factorial * i;
        //    }
        //    Console.WriteLine(factorial);
        //}

        static void mission4()
        {

            Random random = new Random();
            int computerNumber = random.Next(1,11);
            int guesses = 4;

            Console.WriteLine("I have secected a number, if you gues it right, you get a piece of candy! you get 4 tries.");
            Console.WriteLine("My number is between 1 and 10, enther a number to guess");

            for (int i = 0; i < guesses; i++) 
            {
                int userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == computerNumber)
                {
                    Console.WriteLine("You Win!");
                    goto end;
                }
                else
                {
                    Console.WriteLine("Nope! try, again. that was attempt {0}", i+1);
                }
            }
            Console.WriteLine("You Loose!");
            end:;
        }

        //static void mission5()
        //{
        //    //-Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console. For example,
        //    //if the user enters “5, 3, 8, 1, 4", the program should display 8.
        //    Console.Write("Enter commoa separated numbers: ");
        //    var input = Console.ReadLine();



        //}

        static void Main(string[] args)
        {
            mission1();
            mission2();
            //mission3(); //Failed
            mission4();
            //mission5(); //Failed, dont understand
            Console.ReadKey();
        }
    }
}
