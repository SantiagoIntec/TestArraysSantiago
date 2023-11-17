using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbersStad = "9300Aalst,2000Antwerpen,1000Brussel,9200Dendermonde,9000Gent,8500Kortrijk,9700Oudenaarde,2300Turnhout,";
            string varPostNumber;

            int firstPosition;
            int lastpPosition;
            Console.Write("Input post number: ");
            varPostNumber = Console.ReadLine();

            firstPosition = numbersStad.IndexOf(varPostNumber);
            //string var = numbersStad.Substring(lastIndex, numbersStad.IndexOf(','));
            string var = numbersStad.Substring(firstPosition, numbersStad.Length - firstPosition);
            lastpPosition = var.IndexOf(',');
            string result = numbersStad.Substring(firstPosition + 4, lastpPosition - 4);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
