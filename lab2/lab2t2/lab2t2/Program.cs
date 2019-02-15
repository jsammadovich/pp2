using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2t2
{
    class Program
    {
        //prime сандарын тексеру үшін функция ашамын
        public static bool isprime(int b)
        {
            if (b == 1)
            {
                return false;
            }
            for(int i = 2;i * i <= b; i++)
            {
                if (b % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            //текстовый файлды оқу үшін StramReader классын ашамын
            StreamReader str = new StreamReader(@"C:\Users\123\Desktop\PP2\Week 2\task2\task2\input.txt");
            //текстовый файлды көшіру үшін StramReader классын ашамын
            StreamWriter st = new StreamWriter(@"C:\Users\123\Desktop\PP2\Week 2\task2\task2\output.txt");
            string[] s = str.ReadToEnd().Split();
            int[] arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (isprime(arr[i]) == true)
                {
                    st.Write(arr[i] + " ");
                }
            }
            st.Close();
        }
    }
}