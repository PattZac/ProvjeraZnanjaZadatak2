using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi 1. string: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Unesi 2. string: ");
            string s2 = Console.ReadLine();
            if (string.Compare(s1,s2) == 0 || string.Compare(s1, s2) == -1) {
                Console.WriteLine(s1);
                Console.WriteLine(s2);
            }
            else
            {
                Console.WriteLine(s2);
                Console.WriteLine(s1);
            }
            Console.ReadLine();
        }
    }
}
