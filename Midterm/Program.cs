using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetS(32));
        }

        static int GetL(string s){
            int maxLen = 0; 
            int counter = 1; 

            for(int i = 1; i < s.Length; i++){
                if(s[i] == s[i - 1]){
                    counter++;
                } else {
                    if(counter > maxLen){
                        maxLen = counter;
                    }
                    counter = 1;
                }
            }

            if(counter > maxLen){
                maxLen = counter; 
            }

            return maxLen;           
        }

        static int GetS(int n){
            double upperLimit = Math.Pow(2, n);
            int sum = n;

            for(long i = 1; i < upperLimit; i++){
                int l; 
                int[] results = GetSmartBinary(i); 
                int longestChain = results[0]; 
                int length = results[1]; 

                int addition = n - length;
                l = Math.Max(addition, longestChain); 
                
                sum += l; 

                if(i % 1000000 == 0){
                    double x = (double) i; 
                    Console.WriteLine(x / upperLimit);
                }
            }
            return sum;
        }

        static int[] GetSmartBinary(double n){
            n = (int) n; 
            double reminderCurrent; 
            double reminderLast = 2; 
            int counter = 1;
            int maxLen = 0;
            int numberLength = 0;

            while(n > 0){
                n = (int) n; 
                reminderCurrent = n % 2; 
                n = (int) n / 2;

                if(reminderCurrent == reminderLast){
                    counter++; 
                    
                    if(counter > maxLen){
                        maxLen = counter; 
                    }
                } else {
                    counter = 1; 
                }

                reminderLast = reminderCurrent;
                numberLength++; 
            }

            if(counter > maxLen){
                maxLen = counter; 
            }

            return new int[] {maxLen, numberLength}; 
        }

    }
}
