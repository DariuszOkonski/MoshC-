using System;

namespace SandboxNET
{

    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Write your name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;

            }
        }
    }
}
