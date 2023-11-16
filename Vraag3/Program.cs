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
            string postNumbers = "9300,2000,1000,9200,9000,8500,9700,2300";
            string numbersStad = "9300Aalst,2000Antwerpen,1000Brussel,9200Dendermonde,9000Gent,8500Kortrijk,9700Oudenaarde,2300Turnhout";
            string varPostNumber;
            string newPostCode="";
            string newNaamStad="";
            int firstIndex;
            Console.Write("Input post number: ");
            varPostNumber = Console.ReadLine();

            firstIndex = numbersStad.LastIndexOf(varPostNumber);
            string var = numbersStad.Substring(firstIndex,varPostNumber.Length);
            //Console.WriteLine(String.Join(",", postNumbers.Split(',')));
            //Console.WriteLine(var);
            //Console.ReadLine();

            switch (var)
            {
                case "9300":
                    Console.WriteLine("Aalst");
                    break;
                 
                case "2000":
                    Console.WriteLine("Antwerpen");
                    break;

                case "1000":
                    Console.WriteLine("Brussel");
                    break;

                case "9200":
                    Console.WriteLine("Dendermonde");
                    break;

                case "9000":
                    Console.WriteLine("Gent");
                    break;

                case "8500":
                    Console.WriteLine("Kortrijk");
                    break;
                case "9700":
                    Console.WriteLine("Oudenaarde");
                    break;
                case "2300":
                    Console.WriteLine("Turnhout");                              
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
