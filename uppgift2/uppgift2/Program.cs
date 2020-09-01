using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("hello wanna play a guessing game (ja/nej)");
            string svar = Console.ReadLine();

            string svar1 = "nej";
            string svar2 = "ja";

            if (svar == svar1)
            {
                Console.WriteLine("ok bye");
                return;
            }

            else if (svar == svar2)
            {
                Console.WriteLine("ok");
                Console.WriteLine("im thinking of a number rn between 1-10 guess it");

                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("make a guess");
                    int svaret = Convert.ToInt32(Console.ReadLine());

                    if (svaret == 2)
                    {
                        Console.WriteLine("bra jobbat du hittade det");
                        break;
                    }

                    else if (svaret != 2)
                    {
                        Console.WriteLine("lol no");
                        i++;
                    }


                }


            }

            Console.WriteLine("ok now time to guess what letter im thinking");
            char c = 'a';
            char guess = 'b';
            while (guess != c)
            {
                Console.WriteLine("guess a letter");
                guess = Console.ReadKey().KeyChar;

                if (guess == c)
                {
                    Console.WriteLine("ok nice good job");
                    break;
                }
                else
                {
                    Console.WriteLine("no keep guessing");
                }
            }


            Console.WriteLine("ok what number of the day of the week is it today? (1= monday, 2= tuseday etc)");
            int dag = Convert.ToInt32(Console.ReadLine());

            switch (dag)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuseday");
                    break;

                case 3:
                    Console.WriteLine("Wednessday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
