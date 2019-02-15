using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace farmanager_2
{
    class ViewMode
    {
        Dir,
        File
    }
    class Layer
    {
        public FileSystemInfo[] Cont
        {
            get;
            set;
        }
        
        public int SelectedItem
        {
            get;
            set;
        }
        public void Draw
        {
            Console.BackgroundColor = ConsoleColor.Black;       
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
