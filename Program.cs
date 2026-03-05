using System;
using System.Collections.Generic;

namespace SandboxNET
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("++++++++++++");

            var index = numbers.IndexOf(1);
            Console.WriteLine("index: " + index);
            Console.WriteLine("last index: " + numbers.LastIndexOf(1));
        }
    }
}
