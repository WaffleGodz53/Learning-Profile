using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fields
            //int age, currentYear; //Unasigned fields with multiple values
            //string firstName, lastName; //Unasigned fields with multiple values

            Panda p = new Panda("perry"); //Creates Panda named perry with constructor
            bunny b1 = new bunny("Bo");
            Console.WriteLine(b1.name);
            Console.ReadLine(); //For Debugging
        }

        //Methods
        int foo(int x) { return x * 2; } //Simple Method to take int X and multiply by 2;
        int foo2(int x) => x * 2; //Fat arrow can replace single line functions
        void foo3(int x) => Console.WriteLine(x); //The fat arrow can also return a simple command with no return if specified void

        //Method Overloading
        void Foo(int x) { } //Basic Foo
        void Foo(double x) { } //Wait what? as long as the signatures are different multiple mehods can have the same name?!
        void Foo(int x, float y) { } //Wow! multipule paramaters can be passed! who knew ( ͡° ͜ʖ ͡°)
        void Foo(float y, int x) { } //Also works by changing input position of signatures!
        /*What is written below wont work because overloading doesnt work if you only change the return value type
        void foo (int x) {  }
        int foo (int x) {   }
        //Also, did you notice the code block? */

        //Passing by value
        void Pass(int x) { } //Regular data pass
        void Pass(ref int x) { } //Can Coexist with  int overloading
        //void Pass(out int age) { }//out can not exist in the same overload as ref

        //Constructurs
        public class Panda //Constructor Format
        {
            string name; //Define feild
            public Panda(string n)
            {
                name = n;
                Console.WriteLine("The new panda's name is: " + n);
            }
        }

        //Overloading Constuctors
        public class wine //Creates a new constuctor called wine
        {
            public decimal Price;
            public int year;
            public wine(decimal Price) { Price = Price; }
            public wine(decimal Price, int year) : this(Price) { year = year; } //Uhh, what?
        }

        //Object Initalizers
        public class bunny
        {
            public string name;
            public bool LikesCarrots;
            public bool LikesPeople;

            public bunny() { } //Object initializer 1
            public bunny(string n) { name = n; } //Object Initializer 2

        }

        //Properties
        public class stock
        {
            decimal currentPrice, sharesOwned; //privat "backing field"

            public decimal CurrentPrice //Public Property
            {
                get { return currentPrice; } //Get's private value that is not avalible outside of method
                set { currentPrice = value; } //Set's private value to value
            }
            public decimal Worth { get; set; }  //Automatic ???

            public decimal worth
            {
                get { return currentPrice * sharesOwned; } //Read Only
            }

            public decimal worth2 => currentPrice * sharesOwned; //Shorter read only
        }




    }
}
