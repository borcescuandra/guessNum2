using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numarGhicit = rand.Next(0, 100);
            //int numarGhicit = 30;
            int user = 0;

            while (user != numarGhicit)
            {
                Console.Write("Introduceti un numar de la 0 la 100: ");
                int.TryParse(Console.ReadLine(), out user);

                if (user > numarGhicit)
                {
                    Console.WriteLine("{0} este prea mare!", user);
                }
                else if (user < numarGhicit)
                {
                    Console.WriteLine("{0} este prea mic!", user);
                }
                else
                {
                    Console.WriteLine("{0} este numarul corect. Felicitari!", user);
                }
            }
            
        }
    }
}
