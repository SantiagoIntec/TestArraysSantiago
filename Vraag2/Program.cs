using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Vraag2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
                                              "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                                              "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",};            
            string[] password = new string[5];
            int varLetters;
            string nogpassword;

            Random random = new Random();

            do
            {
                

                for (int i = 0; i < 5; i++)
                {

                    varLetters = random.Next(letters.Count());
                    password[i] = letters[varLetters];

                }

                Console.Write($"Password generated: ");
                foreach (string c in password)
                {
                    Console.Write($"{c}");
                }

                Console.Write($"\n Nog een password? j/n : ");
                nogpassword = Console.ReadLine();
                if (nogpassword.ToLower()=="n")
                {
                    break;
                }

            } while (true);



            Console.WriteLine("Dag....");
        }
    }
}
