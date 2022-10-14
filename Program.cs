using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] angles = {30, 15, 37, 115}; 

            // foreach (double angle in angles)
            // {
            //     PrintSinCos(angle);
            // }

            Console.WriteLine("Please, insert the angle value in degrees:  "); 
            double angle_in_degrees = Double.Parse(Console.ReadLine());
            double angle_in_rads = angle_in_degrees * Math.PI / 180;

            PrintSinCos(angle_in_rads);
            
        }

        static void PrintSinCos(double x)
        {
            double sin = Math.Round(Math.Sin(x), 3); 
            double cos = Math.Round(Math.Cos(x), 3); 
            Console.WriteLine("sin({2})={0}, cos({2})={1}", sin, cos, Math.Round(x, 3));
        }
    }
}
