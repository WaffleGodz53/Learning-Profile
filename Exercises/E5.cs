using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Extersizes
{
    class Program
    {
        static void NumberEntery()
        {
            Console.WriteLine("Extersize 1");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Enter a number between 1 & 10");
            JumpPoint:
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: {0}", number);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number between 1 and 10");
                goto JumpPoint;
            }
        }

        static void MaxValue(int a, int b)
        {
            bool firstLarger = false;
            bool secondLarger;
            if (a > b)
            {
                Console.WriteLine("The first number is bigger");
            }
            else if (a < b)
            {
                Console.WriteLine("The second number is bigger");
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
        }



        static void SizeChecker()
        {
            int length;
            int height;
            LengthJump:
            Console.WriteLine("Please enter the lenght of the image in pixels");
            try
            {
                length = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto LengthJump;
            }
            HeightJump:
            Console.WriteLine("Please enter height of image in pixels");
            try
            {
                height = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto HeightJump;
            }
            
            if (length > height)
            {
                Console.WriteLine("The image is landscape");
            }
            else if (length < height)
            {
                Console.WriteLine("The image is portrait!");
            }
            else
            {
                Console.WriteLine("The image is a square!");
            }
        }

        static void SpeedTickiter()
        {
            int speedOfCar;
            int speedLimit;
            int demeritRating;
            SpeedLimitValue:
            Console.WriteLine("Please enter the speed limit");
            try
            {
                speedLimit = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto SpeedLimitValue;
            }
            CarSpeedValue:
            Console.WriteLine("Enter the speed of the car");
            try
            {
                speedOfCar = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                goto CarSpeedValue;
            }

            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int kmPerDemeritPoint = 5;
                demeritRating = ((speedOfCar - speedLimit) / kmPerDemeritPoint);
                if (demeritRating > 12)
                {
                    Console.WriteLine("Liscence suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritRating);
                }
            }
        }

        static void Main(string[] args)
        {
            NumberEntery();
            MaxValue(5,1);
            SizeChecker();
            SpeedTickiter();
            Console.ReadLine();
        }
    }
}