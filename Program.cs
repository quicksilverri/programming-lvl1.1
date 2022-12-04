using System;

namespace DivMod
{
    class Program
    {
        static void Main(string[] args)
        {
            // В трехзначном числе x зачеркнули первую   цифру. 
            // Когда в оставшемся двузначном числе поменяли порядок цифр и 
            // приписали вычеркнутую цифру справа, получилось число n. 
            // По заданному числу n (ввод с клавиатуры, 1≤n≤999 и число единиц не равно нулю) 
            // найти число x. 

            Console.WriteLine("Please, input n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // we'll assume that x = abc, then n = cba 

            int c = n / 100;
            n %= 100; 

            int b = n / 10; 
            int a = n % 10;

            int x = a * 100 + b * 10 + c;
            Console.WriteLine("x = {0}", x);
        }
    }
}
