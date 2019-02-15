using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1t3
{
    class Program
    {
        static void Main(string[] args)
        {
            //айнымалы ашып ,оны қолданылған сан тізіміне сақтаймын
            int n = int.Parse(Console.ReadLine());
            //string массивін ашып ,элементтерін оқып , оларды жеке элментке бөлемін
            string[] arr = Console.ReadLine().Split();
            int k = 0;
            int[] arr2 = new int[n];
            //n*2 өлшеміндегі айнымалы ашамын(сандар екі рет қайталану үшін)
            int[] arr3 = new int[n * 2];
            
            for (int i = 0; i < arr.Length; ++i)
            {
                //массивті екі рет қайталанатын элементтермен толтырамын
                arr2[i] = int.Parse(arr[i]);
            }
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr3[k] = arr2[i];
                arr3[k + 1] = arr2[i];
                k += 2;
            }
            for(int i = 0;i < arr3.Length; ++i)
            {
                //консольге шығарамын
                Console.Write(arr3[i] + " ");
                
            }
            Console.ReadKey();
        }
    }
}
