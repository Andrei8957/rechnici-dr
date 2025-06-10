using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ukazatel = new Dictionary<string, int>();
            string[] tyrsene;
            while (true)
            {
                string ruda = Console.ReadLine();
                if (ruda == "stop")
                {
                    break;
                }
                if(ruda != "gold" && ruda != "silver" && ruda != "coper")
                {
                    Console.WriteLine("Ne broim takava ruda!");
                    return;
                }
                int kol=int.Parse(Console.ReadLine());

                ukazatel[ruda] = kol;

            }
            foreach (var pair in ukazatel)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
