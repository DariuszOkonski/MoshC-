using System;

namespace SandboxNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte number = 250;
                number += 3;

                Console.WriteLine(number);
            }


        }
    }
}
