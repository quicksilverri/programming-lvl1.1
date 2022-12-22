using System;

namespace _2d_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls type two numbers, m and n respectively: ");
            int m = Int32.Parse(Console.ReadLine()); 
            int n = Int32.Parse(Console.ReadLine()); 

            int[,] nums = new int[m, n]; 

            Random rnd = new Random(); 

            for(int i = 0; i < m; i++){
                for(int j = 0; j < n; j++){
                    nums[i, j] = rnd.Next(0, 100);
                }
            }

            PrettyPrint(nums);

            int[] result = IfDescending(nums); 
            if(result[0] == 1){
                Console.WriteLine("The order is wrong! Example: {0}, {1}", result[1], result[2]);
            } else {
                Console.WriteLine("The order is right! Congratz!");
            }

            double[] means = MeanByLine(nums); 

            for(int i = 0; i < means.Length; i++){
                Console.WriteLine("Mean of {0} line is {1}", i + 1, means[i]);
            }
        }

        static void PrettyPrint(int[,] nums){
            for(int i = 0; i < nums.GetLength(0); i++){
                string line = ""; 
                for(int j = 0; j < nums.GetLength(1); j++){
                    line += (nums[i, j].ToString("D2") + " ");
                }
                Console.WriteLine(line); 
            }
        }

        static int[] IfDescending(int[,] nums){
            int[] results = new int[3]; 

            for(int j = 0; j < nums.GetLength(1); j++){
                for(int i = 1; i < nums.GetLength(0); i++){
                    
                    if(nums[i, j] > nums[i - 1, j]){
                        results[0] = 1;
                        results[1] = nums[i - 1, j]; 
                        results[2] = nums[i, j]; 
                        break;
                    }
                }
                
                if(results[0] == 1){
                    break;
                }
            }

            return results;
        }

        static double[] MeanByLine(int[,] nums){
            double[] means = new double[nums.GetLength(0)];

            for(int i = 0; i < nums.GetLength(0); i++){
                double lineTotal = 0;
                for(int j = 0; j < nums.GetLength(1); j++){
                    lineTotal += nums[i, j]; 
                }

                means[i] = lineTotal / nums.GetLength(0); 
            }

            return means;
        }
    }
}
