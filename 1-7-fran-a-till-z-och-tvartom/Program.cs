using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_7_fran_a_till_z_och_tvartom
{
    class Program
    {
        static void Main(string[] args)
        {



            for (byte letter = 65; letter <= 90; letter++)
            {
               Console.Write((char)(letter+32));
               Console.Write((char)(letter));
            }

            Console.WriteLine();

            for (byte letterBackward = 90; letterBackward >= 65; letterBackward--)
            {
                Console.Write((char)(letterBackward+32));
                Console.Write((char)(letterBackward));
            }

            Console.WriteLine();
            



        }
    }
}
