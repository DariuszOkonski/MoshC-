using System;

namespace SandboxNET
{

    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            now.AddDays(5);

            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);
        }
    }
}
