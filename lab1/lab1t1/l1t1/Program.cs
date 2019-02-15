using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t1
{
    class Program
    {
        public static bool Isprime(int a)
        {
            if (a == 1)
                return false;
            for(int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string [] arr = Console.ReadLine().Split();
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(arr[i]);
                if (Isprime(a[i]))
                    Console.Write(a[i] + " ");
            }
            Console.ReadKey();
         
        }
    }
}
