using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GetNumbers();
            PrettyPrint(numbers);
            InvertNumbers(ref numbers); 
            PrettyPrint(numbers);

            int[] binaryNumbers = ToBinary(numbers); 
            PrettyPrint(binaryNumbers);
        }
        static int[] GetNumbers(){
            Console.WriteLine("Pls type a number: ");
            int n = Int32.Parse(Console.ReadLine()); 

            double pi = Math.PI;
            int[] numbers = new int[n];
             
            for(int i = 0; i < n; i++){
                numbers[i] = (int)pi;
                pi = (pi - (int)pi) * 10; 
            }

            return numbers;
        }

        static void PrettyPrint(int[] numbers){
            string line = ""; 
            for(int i = 0; i < numbers.Length; i++){
                line += numbers[i].ToString() + " "; 
                if(i % 10 == 9 | i == numbers.Length - 1){
                    Console.WriteLine(line); 
                    line = "";
                }
            }
        }

        static void InvertNumbers(ref int[] nums){
            for(int i = 0; i < nums.Length; i++){
                nums[i] = 9 - nums[i];
            }
        }

        static int[] ToBinary(int[] nums){
            int[] binaryNums = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++){
                binaryNums[i] = nums[i] % 2; 
            }

            return binaryNums;
        }
    }
}
