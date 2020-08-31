using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Niklas!");

            Console.WriteLine("Vad heter du?");
            String namn = Console.ReadLine();

            Console.WriteLine("Vad är ditt ålder?");
            int age = Console.ReadLine();

            Console.WriteLine("Lever du?");
            String svar = Console.ReadLine();

            String svar1 = "ja";
            String svar2 = "nej";

            if (svar == svar1)
            {
                bool svaret = true;

            }

            if (svar == svar2)
            {
                bool svaret = false;
            }




        }
    }
}
