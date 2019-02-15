using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2t11
{
    class Program
    {
        static void Main(string[] args)
        {
            //текстовый файлдан текстты оқу үшін StreamReader классын ашамын
            StreamReader str = new StreamReader(@"C:/Users/Sammadovich/Desktop/PP2/lab2/t1/input.txt");
            //текст файлдағы элементтерді соңына дейін оқып,string айнымалысына сақтаймын 
            string s = str.ReadToEnd();
            int kol = (s.Length - 1);
            for(int i = 0;i < (s.Length / 2); i++)
            {
                if(s[i] != s[kol])
                {
                    Console.WriteLine("NOOOOO!");
                        Console.ReadKey();
                    return;
                }
                kol--;
            }
            Console.WriteLine("YEEEEES!");
                Console.ReadKey();
        }
    }
}
