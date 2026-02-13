using System;

namespace SandboxNET.Exercises
{
    internal class Exercise_5_1
    {
        public static void RunProgramOne()
        {
            Console.WriteLine("Enter a number between 1-10: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }

        public static void RunProgramTwo()
        {
            Console.WriteLine("Provide two numbers");
            Console.Write("Number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Number 2: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Max: " + number1);
            }
            else
            {
                Console.WriteLine("Max: " + number2);
            }
        }

        public static void RunProgramThree()
        {
            Console.WriteLine("Provide width and height");
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("Square");
            }
        }

        public static void RunProgramFour()
        {
            Console.WriteLine("Speed Camera");
            Console.Write("What is speed limit: ");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.Write("What is current speed: ");
            int currentSpeed = int.Parse(Console.ReadLine());

            const int OVERSPEED_POINTS = 5;

            if (currentSpeed < speedLimit + OVERSPEED_POINTS)
            {
                Console.WriteLine("OK");
                return;
            }


            int overSpeedKilometersPerHour = currentSpeed - speedLimit;
            int demeritPoints = overSpeedKilometersPerHour / OVERSPEED_POINTS;

            if (demeritPoints <= 12)
            {
                Console.WriteLine(string.Format("Overspeed, you have {0} demerit points", demeritPoints));
            }
            else
            {
                Console.WriteLine("Licence suspended");

            }

        }
        public static void Run()
        {
            RunProgramFour();
        }
    }
}
