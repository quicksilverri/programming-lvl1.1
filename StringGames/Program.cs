using System;
using System.Collections.Generic;

namespace StringGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a word in Russian: ");
            string str = Console.ReadLine(); 
            Task1(str);
            Task2();
        }
        
        static void Task1(string str)
        {

            Dictionary<string, string> replacements = new Dictionary<string, string>();

            replacements.Add("А", "A"); replacements.Add("Б", "B"); replacements.Add("В", "V");
            replacements.Add("Г", "G"); replacements.Add("Л", "L"); replacements.Add("Ф", "F");
            replacements.Add("Д", "D"); replacements.Add("М", "M"); replacements.Add("Х", "H");
            replacements.Add("Е", "E"); replacements.Add("Н", "N"); replacements.Add("Ц", "Ts");
            replacements.Add("Ё", "E"); replacements.Add("О", "O"); replacements.Add("Ч", "Ch");
            replacements.Add("Ж", "Zh"); replacements.Add("П", "P"); replacements.Add("Ш", "Sh");
            replacements.Add("З", "Z"); replacements.Add("Р", "R"); replacements.Add("Щ", "Shch");
            replacements.Add("И", "I"); replacements.Add("С", "S"); replacements.Add("Ъ", "Ie");
            replacements.Add("Й", "I"); replacements.Add("Т", "T"); replacements.Add("Ы", "Y");
            replacements.Add("К", "K"); replacements.Add("У", "U"); replacements.Add("Ь", "");
            replacements.Add("Э", "E"); replacements.Add("Ю", "Iu"); replacements.Add("Я", "Ia");
            replacements.Add("а", "a"); replacements.Add("к", "k"); replacements.Add("х", "h");
            replacements.Add("б", "b"); replacements.Add("л", "l"); replacements.Add("ц", "ts");
            replacements.Add("в", "v"); replacements.Add("м", "m"); replacements.Add("ч", "ch");
            replacements.Add("г", "g"); replacements.Add("н", "n"); replacements.Add("ш", "sh");
            replacements.Add("д", "d"); replacements.Add("о", "o"); replacements.Add("щ", "shch");
            replacements.Add("е", "e"); replacements.Add("п", "p"); replacements.Add("ъ", "ie");
            replacements.Add("ё", "e"); replacements.Add("р", "r"); replacements.Add("ы", "y");
            replacements.Add("ж", "zh"); replacements.Add("с", "s"); replacements.Add("ь", "");
            replacements.Add("з", "z"); replacements.Add("т", "t"); replacements.Add("э", "e");
            replacements.Add("и", "i"); replacements.Add("у", "u"); replacements.Add("ю", "iu");
            replacements.Add("й", "i"); replacements.Add("ф", "f"); replacements.Add("я", "ia");

            foreach (char c in str) {
                string new_c = c.ToString();
                string replace_c = new_c;
                
                if (replacements.ContainsKey(new_c)){
                    replace_c = replacements[new_c];
                }
                
                str = str.Replace(new_c, replace_c);
            }

            Console.WriteLine(str);

        }

        static void Task2()
        {
            string x = "чемпионат"; 
            // Console.WriteLine('My word is {0}', x); 
            int[] poncho_index = new int[] {3, 5, 6, 0, 5}; 
            int[] temp_index = new int[] {8, 1, 2, 3};            

            static void PrintWordByIndex(int[] index, string x){
                string word = "";
                foreach (int i in index){
                    word += x[i].ToString();
                    }
                
                Console.WriteLine(word);
            }

            PrintWordByIndex(poncho_index, x);
            PrintWordByIndex(temp_index, x);
        }
    }
}
