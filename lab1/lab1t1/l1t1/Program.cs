using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t1
{
    class Program
    {
        //prime сандарын тексеру үшін функция жазамын
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
        
            //айнымалыны жаңадан ашып , оған сандардың өлшемін сақтаймын
            int n = int.Parse(Console.ReadLine());
            //массив ашып,оларды жеке элементке бөлемін
            string [] arr = Console.ReadLine().Split();
            //сандар массивін ашамын
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                // string элменттерін int массивіне сақтаймын
                a[i] = int.Parse(arr[i]);
                if (Isprime(a[i]))
                    Console.Write(a[i] + " ");
            }
           
            Console.ReadKey();
         
        }
    }
}
