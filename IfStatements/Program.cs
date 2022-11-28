using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args){
            TaskOne();
            TaskTwo();
        }
        
        static void TaskOne()
        {
            // Числа k, m и n удовлетворяют неравенствам треугольника, т. е. сумма любых двух из них меньше третьего
            Console.WriteLine("First task! Pls write down 3 numbers :)");
            double k = ImportDouble("Type k: ");
            double m = ImportDouble("Type m: ");
            double n = ImportDouble("Type n: ");

            static bool IfTriangleInequality(double a, double b, double c) {
                return (a + b > c);
            }

            if (IfTriangleInequality(k, m, n) && IfTriangleInequality(m, n, k) && IfTriangleInequality(n, k, m)) {
                Console.WriteLine("m, n, k DO suffice Triangle Inequality");
            }
            else {
                Console.WriteLine("m, n, k DO NOT suffice Triangle Inequality");
            }

        }

        static void TaskTwo()
        {
            Console.WriteLine("Second task! Pls write down x and y coordinates :)");
            double x = ImportDouble("Type x: ");
            double y = ImportDouble("Type y: ");

            static void PrintIfBelongs(double x, double y){
                if ((x > 1) || (x < -3)) {
                    Console.WriteLine("Given (x;y) DO belong to the set");
                }
                else {
                    Console.WriteLine("Given (x;y) DO NOT belong to the set"); 
                }
            }

            PrintIfBelongs(x, y);
        }

        static double ImportDouble(string inputStatement){
            Console.WriteLine(inputStatement);
            return Double.Parse(Console.ReadLine());
        }



        
    }
}
