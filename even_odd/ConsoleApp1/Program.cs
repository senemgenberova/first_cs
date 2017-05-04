using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
            int reqem = Convert.ToInt32(Console.ReadLine());

                if (reqem % 2 == 0)
                {
                    reqem = (int)Math.Pow(reqem, 2);
                }
                else
                {
                    reqem = (int)Math.Pow(reqem, 3);
                }
                Console.WriteLine(reqem);
                Console.ReadKey();
        }
    }
}
