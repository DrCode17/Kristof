using System;
using System.IO; //file írás olvasás
using System.Linq; //listaműveletek

namespace Alapok{
    class Program{
        public static void Main(){
            Console.WriteLine("Hello");
            //változók típusai
            //int - egész szám
            //float - tört szám
            //string - szöveg
            //char - karakter
            //bool - Treu/False

             int valtozonev = 5;
             //float valtozonev2 = 4.5;
             string valtozonevs1 = "5"; 
             string valtozonevs2 = "2"; 
             //char c = 'a';
             //bool igaz = true;

             Console.Write("Adj meg egy számot: ");
             int szam = int.Parse(Console.ReadLine());
             //Console.WriteLine(valtozonev2);
         
             Console.WriteLine(valtozonevs1 + int.Parse(valtozonevs2));
             int szam1 = 3;
             float szam2 = 4.5f;

             Console.WriteLine(szam2/szam1);
             Console.WriteLine(szam2*szam1);
             Console.WriteLine(szam2-szam1);
             Console.WriteLine(szam2+szam1);

             //maradékos osztás
             int maradek = szam1 % 3;







        }
    }

}