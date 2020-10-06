using System;

namespace Laboration1OOP
{
    class Program
    {
        static void Main(String[] args)
        {
            String awnser1 = "yes";
            String awnser2 = "no";

            Kund _nykund = new Kund();

            Console.WriteLine("What is your name?");
            _nykund._name = Console.ReadLine();

            Console.WriteLine("-----------------------------");


            Console.WriteLine("How old are you?");
            _nykund._age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------------------");

            Produkt _nyprodukt = new Produkt();

            Console.WriteLine("Do you want milk? (yes/no)");
            String awnser = Console.ReadLine();

            if(awnser == awnser1)
            {
                _nyprodukt._milk = true;
                Console.WriteLine("How many packets of milk do you want? (write a number)");
                _nyprodukt._amountMilk = Convert.ToInt32(Console.ReadLine());
            }

            if (awnser == awnser2)
            {
                _nyprodukt._milk = false;
                _nyprodukt._amountMilk = 0;
            }

            Console.WriteLine("-----------------------------");

            Console.WriteLine("The customer is: " + _nykund._age + " years old");
            Console.WriteLine("his name is: " + _nykund._name);

            if (_nyprodukt._milk == true)
            {
                Console.WriteLine("The customer is buying milk");
                Console.WriteLine("Exactly " + _nyprodukt._amountMilk + " packets of milk");

            }

            if (_nyprodukt._milk == false)
            {
                Console.WriteLine("The customer is not buying milk");
                

            }


        }





    }
}
