using System;

namespace Program{
    class Program{
        static void Main(){
            Console.WriteLine("Hello!"); //szövegnél kell "" !!
            /*int szam = int.Parse(Console.ReadLine()); //szám bekérése
            //string szoveg = Console.ReadLine();       //szöveg bekérése
            Console.WriteLine(szam); //változónál nem kell "" !!
            szam += 5; //szam = szam + 5
            szam -= 5; //szam = szam -5
            szam /= 5;
            szam *= 5;
            szam %= 5; //számba a szam 5-el való osztási maradéka kerül.

            //Feladat: Kérjen be egy pénzösszeget, majd mondja meg, minimum hány apróval lehet kifizetni.
            Console.Write("Adjon meg egy pénzösszeget: ");
            int penzosszeg = int.Parse(Console.ReadLine());
            int ketszaz = penzosszeg / 200;
            penzosszeg %= 200;
            int szaz = penzosszeg / 100;
            penzosszeg %= 100;
            int otven = penzosszeg / 50;
            penzosszeg %= 50;
            int husz = penzosszeg / 20;
            penzosszeg %= 20;
            int tiz = penzosszeg / 10;
            penzosszeg %= 10;
            int ot = penzosszeg / 5;
            penzosszeg %= 5;
            int ketto = penzosszeg / 2;
            penzosszeg %= 2;
            int egy = penzosszeg / 1;
            penzosszeg %= 1;

            Console.WriteLine("200: " + ketszaz + ", 100: " + szaz + ", 50: " + otven + ", 20: " + husz + ", 10: " + tiz + ", 5: " + ot + ", 2: " + ketto + ", 1: " + egy);
            
            for(int i = 1; i < 101; i++){
                if(i%4 == 0){
                    Console.Write("Fizz");
                }
                if(i%6 == 0){
                    Console.Write("Buzz");
                }

                if(i%6 == 0 || i%4 == 0){ //Vagy 6-al vagy 4-el vagy mindkettővel osztható 
                    Console.WriteLine();
                }
                if(i%6 != 0 && i%4 != 0){
                    Console.WriteLine(i);
                }
            }

            //feladat Bekérünk 3 számot és a legkisebbet kiírjuk a képernyőre.
            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int c = int.Parse(Console.ReadLine());


            if(a < b){
                if(a < c){
                    Console.WriteLine(a);
                }
            }
            if(b < a){
                if(b < c){
                    Console.WriteLine(b);
                }
            }
            if(c < a){
                if(c < b){
                    Console.WriteLine(c);
                }
            }
            */

            //Feladat: Kérj be 3számot, bármelyik 2 összege egynlő-e a harmadikkal?
            Console.Write("Adj meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Adj meg egy számot: ");
            int c = int.Parse(Console.ReadLine());

            if(a+b == c){
                Console.WriteLine("a+b=c");
            }else if(b+c == a){
                Console.WriteLine("b+c=a");
            }else if(c+a == b){
                Console.WriteLine("c+a=b");
            }else{
                Console.WriteLine("Egyik két szám összege sem egyenlő a harmadikkal.");
            }


            //  Visual Studioban kell!!!  Console.ReadKey();
        }
    }
}