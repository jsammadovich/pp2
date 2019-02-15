using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3t1
{
    enum FSIMode
    {
        Dir,
        File,
        Zip
    }
    class Program
    {
        static void Main(string[] args)
        {
            FSIMode mode = FSIMode.Zip;
            int md2 = 2;
            //zip - 2;
            //file - 1;
            //dir - 0;
            if(md2 == 0)
            {
                Console.WriteLine("DIR");
            }
            else if(md2 == 1)
            {
                Console.WriteLine("FILE");
            }
            else if(md2 == 2)
            {
                Console.WriteLine("ZIP");
            }
            if (mode == FSIMode.Dir)
            {
                Console.WriteLine("DIR");
            }
            else if (mode == FSIMode.File)
            {
                Console.WriteLine("FILE");
            }
            else if(mode == FSIMode.Zip)
            {
                Console.WriteLine("ZIP");
            }
        }
    }
}
