using System;

namespace SandboxNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overflowing
            checked
            {
                byte number = 250;
                number += 3;

                Console.WriteLine(number);
            }


        }
    }
}
