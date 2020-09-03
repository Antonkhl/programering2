using System;
using System.Linq;

namespace namnlista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Du ska skriva in 5 namn! good luck!");

            string []names = new string[5];

            for(int i = 0; i < names.Length ; i++)
            {
                names[i] = Console.ReadLine();
            }

            Array.Reverse(names);

         foreach(string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
