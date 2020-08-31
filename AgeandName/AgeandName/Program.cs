using System;
using System.Globalization;

namespace AgeandName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Write your age");

           int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age is " + age);

            Console.WriteLine("Now, write your name!");
            string name = Console.ReadLine();
            Console.WriteLine("your name is " + name);

            Console.WriteLine("Are you alive???? (ja/nej)");
            string svaret = Console.ReadLine();


            string svar1 = "ja";
            string svar2 = "Ja";
            string svar3 = "nej";
            string svar4 = "Nej";

            if (svaret == svar1 || svaret == svar2)
            {
                Console.WriteLine("du är " + age + " gammal och du heter " + name + " och du är vid liv");
            }

            if (svaret == svar3 || svaret == svar4)
            {
                Console.WriteLine("du är " + age + " gammal och du heter " + name + " och du är inte vid liv");
            }



        }
    }
}
