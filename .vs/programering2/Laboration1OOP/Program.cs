﻿using System;

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

            Produkt customerMilk = new Milk();
            Produkt customerEgg = new Egg();
            Produkt customerEgg = new Bread();

            Console.WriteLine("Do you want milk?")
            String awnser = Console.ReadLine();

            if(awnser == awnser1)
            {
                customerMilk.productWant();
            }

            if (awnser == awnser2)
            {
                customerMilk.productWant();
            }

            Console.WriteLine("Do you want Egg?")
            String awnser = Console.ReadLine();


            if (awnser == awnser1)
            {
                customerEgg.productWant();
            }

            if (awnser == awnser2)
            {
                customerMilk.productWant();
            }









        }
    }
