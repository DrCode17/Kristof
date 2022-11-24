using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Adj meg egy számot: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Adj meg egy számot: ");
            int c = int.Parse(Console.ReadLine());

            if(a % 2 == 0)//if után nincs ; !!!
            {
                if(b % 2 == 0)//if után nincs ; !!!
                {
                    if(c % 2 == 0)//if után nincs ; !!!
                    {
                        Console.WriteLine("Igen");
                    }
                    else
                    {
                        Console.WriteLine("Nem");
                    }
                }
                else
                {
                    Console.WriteLine("Nem");
                }
            }
            else
            {
                Console.WriteLine("Nem");
            }

            for (int i = 1; i < 101; i++)
            {
                if(i % 12 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 4 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 6 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam % 6 == 0)
            {
                Console.WriteLine("2-vel és 3-al is osztható");
            }
            else if (szam % 2 == 0)
            {
                Console.WriteLine("2-vel osztható");
            }
            else if(szam % 3 == 0)
            {
                Console.WriteLine("3-al osztható");
            }
            else
            {
                Console.WriteLine("Nem osztahtó 2-vel és 3-al");
            }*/

            Console.Write("Adj meg egy számot");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Adj meg egy számot");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Adj meg egy számot");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("A-a legkisebb szám");
            }
            if (b < c && b < a)
            {
                Console.WriteLine("B-a legkisebb szám");
            }
            if (c < a && c < b)
            {
                Console.WriteLine("C-a legkisebb szám");
            }


            Console.ReadKey();
        }
    }
}
