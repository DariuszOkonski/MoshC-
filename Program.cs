using SandboxNET.Math;
using System;

namespace SandboxNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";

            john.Introduce();

            Calculator calculator = new Calculator();

            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
