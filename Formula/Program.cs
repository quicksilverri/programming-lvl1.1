using System;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls input x: "); 
            double x = Double.Parse(Console.ReadLine()); 
            PrintResult(x);
        }

        static void PrintResult(double x){
            double result;
            if (x < -2){
                result = Math.Sqrt(x * x + 4);
            }
            else if (x <= 1){
                result = 1 / (x * x +1);
            }
            else {
                result = Math.Sqrt(x * x - 1);
            }

            Console.WriteLine(result);
        }
    }
}
