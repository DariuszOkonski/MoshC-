using System;

namespace SandboxNET
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 7, 9, 2, 14, 6 };


            Console.WriteLine("Lenght: " + numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("index: " + index);

            Array.Clear(numbers, 0, 2);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("=======");

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("+++++++");
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------");
            Array.Reverse(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
