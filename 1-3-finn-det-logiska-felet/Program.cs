﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_finn_det_logiska_felet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Finn det logiska felet";

            //Namngiven konstant (symbolisk konstant)
            const int Rate = 25;    //moms i procent

            //Definierar och inititerar variabler
            double cost = 0d; //varans pris
            double tax = 0d; //moms i kronor
            double totalCost = 0d; //kostnad för en vara inkl. moms

            //Användaren matar in priset.
            Console.Write("Ange varans pris exkl. moms");
            cost = Double.Parse(Console.ReadLine());

            //Beräknar momsen
            tax = Rate * cost / 100;

            //Beräkna den totala kostnaden
            totalCost = cost + tax;

            //Presenterar resultatet
            Console.WriteLine("Varans pris inkl. moms är {0:c}.", totalCost);
           
        }
    }
}
