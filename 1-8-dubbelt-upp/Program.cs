using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8_dubbelt_upp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valueHolder = {10,23,5,1,15};

            foreach (int value in valueHolder){
                Console.Write("{0} ",value);            
            }

            valueHolder[1] *= 2;
            valueHolder[4] *= 2;

            Console.WriteLine();

            foreach (int value in valueHolder)
            {
                Console.Write("{0} ", value);
            }

            Console.WriteLine();


        }
    }
}
