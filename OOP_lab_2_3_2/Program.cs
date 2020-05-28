using System;
using System.Reflection.Metadata.Ecma335;

namespace OOP_lab_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.25;

            while (x <= 6.75)
            {
                double y = Math.Pow(x, 1 / 3) + Math.Log(3 * x);

                Console.WriteLine("x = {0:f2}, y = {1:f4}", x, y);

                x += 0.25;
            }
        }
    }
}
