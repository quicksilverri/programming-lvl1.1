using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // TaskOne();
            // TaskTwo();
            TaskThree(); 
        }

        static void TaskOne(){
            Console.WriteLine("Pls input n: ");
            int n = Int32.Parse(Console.ReadLine());
            double result = 0;

            for(double i = 1; i < n + 1; i++){
                result += (i + 1) / i;
                // Console.WriteLine(result);
            }

            Console.WriteLine(result);
        }

        static void TaskTwo(){
            Console.WriteLine("Start writing numbers: "); 
            int newNumber = Int32.Parse(Console.ReadLine());
            int count = 0; 

            while (newNumber != 0){
                newNumber = Int32.Parse(Console.ReadLine()); 
                count++; 
            }

            Console.WriteLine("total of {0} numbers", count);
        }

        static void TaskThree(){
            Console.WriteLine("Pls print a number: "); 
            int n = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("1"); 

            for(int i = 1; i < n; i++){
                string line = "1"; 
                for(int j = 1; j < i; j++){
                    int newNumber = Factorial(i) / (Factorial(j) * Factorial(i - j));
                    line += (" " + newNumber);
                }

                Console.WriteLine(line + " 1"); 
            }
        }

        static int Factorial(int n){
            int result = 1; 
            while (n != 1){
                result *= n; 
                n -= 1;
            }

            return result; 
        }
    }
}
