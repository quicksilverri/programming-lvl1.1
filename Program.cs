using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angles = {30, 15, 37, 115}; 

            foreach (double angle in angles)
            {
                double sin = Math.Round(Math.Sin(angle * Math.PI / 180), 3); 
                double cos = Math.Round(Math.Cos(angle * Math.PI / 180), 3); 
                Console.WriteLine("sin({2})={0}, cos({2})={1}", sin, cos, angle); 
            }
        }
    }
}
