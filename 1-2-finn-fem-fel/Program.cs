using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_finn_fem_fel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn fem fel";

            //definiera och initiera varibler
            int hours = 35; //antal arbetstimmar per vecka
            double hourlyWages = 173.27; //timlön

            //beräkna lön
            double weeklyWages;
            weeklyWages = hourlyWages * hours;
             
            //presentera resultatet
            Console.WriteLine("Veckolönen är {0:c}.\n", weeklyWages);
        }
    }
}
