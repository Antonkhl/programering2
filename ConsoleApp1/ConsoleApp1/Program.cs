using System;

namespace Laboration1OOP
{
    class Program
    {
        static void Main(String[] args)
        {
            String awnser1 = "yes";

            Kund _nykund = new Kund();

            Console.WriteLine("What is your name?");
            _nykund._name = Console.ReadLine();

            Console.WriteLine("-----------------------------");


            Console.WriteLine("How old are you?");
            _nykund._age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------");

            Produkt customerMilk = new Milk();
            Produkt customerEgg = new Egg();
            Produkt customerBread = new Bread();

            Console.WriteLine("Do you want milk?");
            String awnserA = Console.ReadLine();

            if (awnserA == awnser1)
            {
                customerMilk.productWant();
                Console.WriteLine("Do you want milk?");
            }

           
            Console.WriteLine("Do you want Egg?");
            String awnserB = Console.ReadLine();


            if (awnserB == awnser1)
            {
                customerEgg.productWant();
            }


            Console.WriteLine("Do you want Bread?");
            String awnserC = Console.ReadLine();


            if (awnserC == awnser1)
            {
                customerBread.productWant();
              
            }

            Console.WriteLine("-----------------------------");

          















        }
    }
}
