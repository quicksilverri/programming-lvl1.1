using System;

namespace MathFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double sin = Math.Sin(Math.Sqrt(Math.Pow(x, 2) + 4) / 2);
            double cos = Math.Cos(Math.Sqrt(Math.Pow(x, 2) + 1) / 2); 

            Console.WriteLine("Answer: {0}", Math.Round(2 * sin * cos, 3)); 
        }
    }
}
