using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_1
{
    class Program
    {
        static void exercise1()
        {
            var names = new List<string>();
            bool enteringNames = true;
            while (enteringNames)
            {
                Console.WriteLine("Enter a name or hit enter to quit");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "":
                        enteringNames = false;
                        break;
                    default:
                        names.Add(input);
                        break;
                }
            }
            switch (names.Count)
            {
                case 0:
                    Console.WriteLine("Do Nothing(for debugging)");
                    break;
                case 1:
                    Console.WriteLine("{0} liked your post!", names[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post!", names[0], names[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1}, and {2} other's liked your post!", names[0], names[1], names.Count - 2);
                    break;
            }
        }

        static void exercise2() //Why does this work?
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        //3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. 
        //Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        static void exercise3()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }
            numbers.Sort();
            foreach (var number in numbers)
                Console.Write(number);
        }


        //4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.
        static void exercise4()
        {
            var Inputlist = new List<string>();
            while (true)
            {
                Console.WriteLine(@"Enter a number or type 'Quit' to exit");
                
                var input = Console.ReadLine();
                switch (input)
                {
                    case "Quit":
                        goto Break;
                    default:
                        Inputlist.Add(input);
                        break;
                }
            }
            Break:;
            Console.WriteLine("Number's Entered");
            for (var i = 0; i < Inputlist.Count; i++)
            {
                Console.Write("{0}, ", Inputlist[i]);
            }
        }

        //static void exercise5() //Dont Understand (Make a list that takes user input and chops up to just numbers and echo back las 3 enteries to user.
        //List must be at least 5 long or tell user to try again)
        //{
        //    Console.WriteLine(@"Enter a list of numbers seperated by comma's. (e.g: 1, 2, 3, 4, 5)");
        //    var enteredNumbers = new List<string>();
        //    var input = Console.ReadLine();

        //}

        static void Main(string[] args)
        {
            exercise1();
            exercise2();
            exercise3();
            exercise4();

            Console.ReadKey();
        }
    }
}
