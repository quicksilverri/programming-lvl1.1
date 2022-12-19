﻿using System;
using System.Collections.Generic;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args){
            // TaskOne();
            // TaskTwo();
            TaskThree();
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

        static void TaskThree(){
            // ферзь ферзь 

            static Dictionary<string, int> DecodePosition(string position){
                // position column(letter)+row(number) 
                // REWRITE FOR >OUT< PARAMETR  
                Dictionary<string, int> replacements = new Dictionary<string, int>();
                replacements.Add("a", 1); replacements.Add("b", 2); replacements.Add("c", 3); replacements.Add("d", 4);
                replacements.Add("e", 5); replacements.Add("f", 6); replacements.Add("g", 7); replacements.Add("h", 8);

                string rawRow = position.Substring(0, 1);
                string rawCol = position.Substring(1, 1); 

                int row = replacements[rawRow]; 
                int col = Int32.Parse(rawCol);

                Dictionary<string, int> results = new Dictionary<string, int>();
                results.Add("col", col); results.Add("row", row);                
                return results;                
            }

            static string InputData(sting inputStatement){
                Console.WriteLine(inputStatement);
                string position = Console.ReadLine();

                return position;
            }

            static bool ifMovementPossible(var posA, var posB){
                
            }

            static bool ifTheyBeatEO(var posA, var posB){
                
            }

            var white = InputData("Pls input white figure position: ");
            var black = InputData("Pls input black figure position: ");
            var move = InputData("Pls input desired position for white figure: "); 

            var positionWhite; var positionBlack; var positionMove; 

            DecodePosition(out white)


        }
    }
}
