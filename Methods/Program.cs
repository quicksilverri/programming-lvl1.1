using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFormula(2, 3) + CalculateFormula(5, 7));
        }
        
        static double CalculateFormula(double x, double y)
        {
            double top = Math.Sin(x) + Math.Sin(y);
            double bottom = Math.Cos(x) + Math.Cos(y);
            
            return Math.Round(top / bottom, 3);

        }
    }
}
