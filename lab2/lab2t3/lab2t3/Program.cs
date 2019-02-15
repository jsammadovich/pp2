using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2t3
{
    class Program
    {
        //TAB қолдану үшін функция ашамын
        public static void PrintSpaces(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write("    ");
            }
        }
        //барлық папкалардың көрсетілген жолмен көрсетілуі үшін функция ашамын
        public static void Direct(DirectoryInfo dir,int a)
        {
            foreach(FileInfo f in dir.GetFiles())
            {
                PrintSpaces(a);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo dir2 in dir.GetDirectories())
            {
                PrintSpaces(a);
                Console.WriteLine(dir2.Name);


                Direct(dir2, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:/Users/Sammadovich/Desktop/PP2/Dir");
            int b = 0;
            Direct(dirinfo, b);
            Console.ReadKey();

        }
    }
}
