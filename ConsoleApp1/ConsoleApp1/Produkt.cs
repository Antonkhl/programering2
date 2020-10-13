using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Laboration1OOP
{
    class Produkt
    {

        public virtual void productWant()
        {
            Console.WriteLine("This customer dosent want anything");
        }

    }

    class Milk : Produkt
    {
        public override void productWant()
        {
            Console.WriteLine("This customer wants milk");
        }
    }

    class Egg : Produkt
    {
        public override void productWant()
        {
            Console.WriteLine("This customer wants Egg");
        }
    }

    class Bread : Produkt
    {
        public override void productWant()
        {
            Console.WriteLine("This customer wants Bread");
        }
    }


}
