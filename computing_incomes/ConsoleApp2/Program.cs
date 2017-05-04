using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int gunluk_gelir = Convert.ToInt16(Console.ReadLine());
            int gun_sayi = Convert.ToInt16(Console.ReadLine());
            int brut_gelir = gunluk_gelir * gun_sayi;
            double faiz;

            if(brut_gelir >= 1000)
            {
                faiz = brut_gelir * 0.18;
            }
            else
            {
                faiz = brut_gelir * 0.04;
            }

            double net_gelir = brut_gelir - faiz;

            Console.WriteLine("Faiz: " + faiz);
            Console.WriteLine("Net gelir: " + net_gelir);
            Console.ReadKey();
        }
    }
}
