using System;

namespace SandboxNET
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail,
        Express
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else
            {
                Console.WriteLine("It's evening");
            }




        }
    }
}
