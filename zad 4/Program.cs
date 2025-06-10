using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> ukazatel = new Dictionary<string, double>();
            double cena = 0;
            int kolichestvo = 0;
            List<double> ceni = new List<double>();
            List<int> kolichestva = new List<int>();
            double suma = 0;
            while (true)
            {

                string[] list = Console.ReadLine().Split(' ').ToArray();
                if (list.Length > 4)
                {
                    Console.WriteLine("Tvyrde mnogo danni");
                    return;
                }
                if (list[0] == "stocked")
                {
                    break;
                }

                string stoka = list[0];
                cena = double.Parse(list[1]);
                ceni.Add(double.Parse(list[1]));
                kolichestva.Add(int.Parse(list[2]));
                kolichestvo = int.Parse(list[2]);
                double rezult = cena * kolichestvo;
                ukazatel[stoka] = rezult;
                suma += rezult;

            }
            int n = 0;
            foreach (var pair in ukazatel)
            {
                Console.Write($"{pair.Key}: ");

                for (int i = n; i < ceni.Count; i++)
                {
                    Console.Write($"{ceni[i]} * {kolichestva[i]} ");
                    break;
                }
                Console.WriteLine($"= ${pair.Value:f2}");
                n++;
            }
            Console.WriteLine("--------------");
            Console.WriteLine($"Grand Total: ${suma}");

        }
    }
}
