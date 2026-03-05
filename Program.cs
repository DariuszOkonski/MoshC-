using System;

namespace SandboxNET
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //var matrix = new int[3, 5]
            //{
            //    {1,2,3,4,5 },
            //    {6,7,8,9,10 },
            //    {11,12,13,14,15 }
            //};

            //Console.WriteLine(matrix[0, 2]);
            var array = new int[3][];
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            Console.WriteLine(array[0][1]);


        }
    }
}
