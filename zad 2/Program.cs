using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> ukazatel = new Dictionary<string, long>();
            string tip = "";
            string[] tyrsene;
            while (true)
            {

                string[] list = Console.ReadLine().Split(' ').ToArray();
                if (list.Length >3)
                {
                    Console.WriteLine("Tvyrde mnogo danni");
                    return;
                }
                if (list[0] == "END")
                {
                    break;
                }   
               
                tip = list[0];
                if (tip == "S")
                {
                    string name = list[1];
                    if (ukazatel.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {ukazatel[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                if (tip == "A")
                {
                    string name = list[1];
                    long number =long.Parse(list[2]);

                    ukazatel[name] = number; 
                }
               
            }
        }
    }
}
