using System;

namespace Elso{
    class Program{
        public static void Main(){
            //int egesz = 5; //int.Parse
            //float tort = 4.5;
            //string szoveg = "abcde";
            //if, for  NINCS utána pontosvessző!!!
            Console.Write("Adj meg egy számot: "); //Kiír
            int szam1 = int.Parse(Console.ReadLine()); //Bekér
            Console.Write("Adj meg még egy nagyobb számot: "); //Kiír
            int szam2 = int.Parse(Console.ReadLine()); //Bekér
            //                start           stop+1    lepes köz
            for (int szamok = szam1; szamok < szam2+1; szamok++) //++ -> +1 , +2 -> +2
            {
                if (szamok%2==0)
                {
                    Console.WriteLine(szamok);
                }
            }
            /*
            if(szam1%2==1)
            {
                szam1++; // szam1 = szam1 + 1; szamok1 += 1;
            }
            if (szam2%2 == 1)
            {
                szam2--; // szam2 = szam2 - 1; szamok2 -= 1;
            }

            for (int szamok = szam1; szamok < szam2+1; szamok+=2)
            {
                Console.WriteLine(szamok);
            }*/

            Console.Write("Adja meg a pontszámát:");
            int x = int.Parse(Console.ReadLine());

            if (x < 50){
                Console.WriteLine("1-es");
            }else if( x < 60){
                Console.WriteLine("2-es");
            }else if(x < 70){
                Console.WriteLine("3-as");
            }else if(x < 85){
                Console.WriteLine("4-as");
            }else{
                Console.WriteLine("5-os");
            }


            //Console.ReadKey();
        }
    }
}