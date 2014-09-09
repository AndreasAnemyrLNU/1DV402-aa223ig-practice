using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_Konvertera_Fahrenheit_till_Celcius
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklarerar variabler
            double fahrenheit;
            double celcius;

            //Här ber vi användaren att mata in ett värde i konsollen.
            Console.Write("Ange temperaturen i grader Fahrenheit: ");

            //Nästa steg är introtext för användare!
            
            // Bortkommenterar simulerat värde för fahrenheit = 73;
            fahrenheit = int.Parse(Console.ReadLine());

            //Här beräknar vi värde Celsius -> Fahrenheit
            celcius = (fahrenheit - 32) * 5 / 9;

            //Här presenteras värdet tillbaka till användaren, avrundat EN decimal

            Console.WriteLine("Temperaturen {1:f1} °F motsvarar {0:f1} °C",celcius,fahrenheit);

        }
    }
}
