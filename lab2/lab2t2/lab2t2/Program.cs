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
            Str
        }
    }
}
