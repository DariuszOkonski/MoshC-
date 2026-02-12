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
            var number = 1;
            Increment(number);

            Console.WriteLine(number);
            Console.WriteLine("===============");

            var person = new Person()
            {
                Age = 20
            };

            MakeOld(person);

            Console.WriteLine("Perons.Age: " + person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine("Inside: " + number);
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }

    }
}
