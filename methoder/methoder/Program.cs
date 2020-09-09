using System;
using System.Linq;

namespace methoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[3] { 3, 5, 6 };
            heltal(lista);

            string[] ord2 = new string[3] {"hej", "Hur", "mar" };
            ord(ord2);

            int[] listatal = new int[3] { 5, 8, 2 };
            listaMaxMin(listatal);

            result(lista, ord2, listatal);
        }
         
       static void heltal(int[] lista)
        {
            Console.WriteLine(lista.Sum());
            return;

        }

        static void ord(string[] ord)
        {
            Array.Reverse(ord);
            
           foreach(string i in ord)
            {
                Console.WriteLine(i);
            }
           
        }

        static void listaMaxMin(int[] listatal)
        {
            Console.WriteLine(listatal.Max());
            Console.WriteLine(listatal.Min());
            return;

        }

     
        static void result(int[] lista, string[] ord2,int[] listatal)
        {
            Console.WriteLine(lista.Sum());

            foreach (string i in ord2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(listatal.Max());
            Console.WriteLine(listatal.Min());
           return;
        }

    
    }
}
