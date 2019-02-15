using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2t4
{
    class Program
    {
        static void Main(string[] args)
        {   
            //файлды жаңадан ашу үшін,ашу жолдарын белгілеймін
            string path1 = Console.ReadLine();
            //файлы қайда көшіру үшін,көшіру жолдарын белгілеймін
            string path2 = Console.ReadLine();
            //бірінші жолды файлдың атымен комбинация жасаймын
            path1 = Path.Combine(path1, "example.txt");
            //екінші жолды файлдың атымен комбинация жасаймын
            path2 = Path.Combine(path2, "example.txt");

            //Бірінші жол бойынша жаңадан файл ашамын
            FileStream fs = File.Create(path1);

            //Потокты жабамын
            fs.Close();

            //Файлды path1 ден path2 ге көшіремін
            File.Copy(path1, path2, true);

            //Берілген жол бойынша файлы өшіремін
            File.Delete(path1);
        }
    }
}
