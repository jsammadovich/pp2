using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1t4
{
    class Program
    {
        static void Main(string[] args)
        {
            //айнымалы ашып ,оған массивтің размерін сақтаймын
            int n = int.Parse(Console.ReadLine());
            //string - те 2d массив ашамын
            string[,] arr = new string[n, n];
            //массив ішін [*] символымен толтырамын
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] += "[*]";
                }
            }
            //консольге керек символдарды шығарамын
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j)
                        Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
