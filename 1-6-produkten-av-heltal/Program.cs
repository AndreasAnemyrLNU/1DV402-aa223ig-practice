using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6_produkten_av_heltal
{
    class Program
    {
        static void Main(string[] args)
        {

            long product = 1;
       

            for (int i = 1; i <= 20 ; i++)
            {

                product *= i;
            }
        Console.WriteLine("Summan av alla heltal mellan 1 och 20 är {0}", product);
        }
    }
}
