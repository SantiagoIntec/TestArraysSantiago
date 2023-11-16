using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestArraysSantiago
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] factuur = new decimal[1];
            

            Console.Write("Bedrag van factuur: ");
            factuur[0] = decimal.Parse(Console.ReadLine());

            if (factuur[0] > 5000)
            {
                factuur[0] = factuur[0] - factuur[0]*5/100;
                Console.WriteLine($" Factuur met 5% korting: {factuur[0]}");
            }
            else
            {
                Console.WriteLine($" Factuur zonder korting: {factuur[0]}");
            }
            Console.ReadLine();
        }
    }
}
