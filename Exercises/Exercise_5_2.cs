using System;

namespace SandboxNET.Exercises
{
    internal class Exercise_5_2
    {
        public static void RunProgramOne()
        {
            const int numbersLength = 100;
            int divisibleByThree = 0;

            for (int i = 1; i <= numbersLength; i++)
            {
                if (i % 3 == 0)
                {
                    divisibleByThree++;
                }
            }

            Console.WriteLine("Quantity divisible by 3: " + divisibleByThree);


        }

        public static void RunProgramTwo()
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter OK finish program");
                Console.Write("Enter a number: ");
                var number = Console.ReadLine();

                if (number.ToLower() == "ok")
                {
                    break;
                }

                sum += int.Parse(number);
            }

            Console.WriteLine("Sum: " + sum);
        }
        public static void Run()
        {
            RunProgramTwo();
        }
    }
}
