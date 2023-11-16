using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 93, 4, 15 };
            int som = 0; 
            int buffer = 0;
            for (int i = 0; i < numbers.Length; i++) 
            {
                
                som += numbers[i]; 
            }
            Console.WriteLine($"Sum :  {som} grooste number : {numbers.Max()}");
        }
    }
}
