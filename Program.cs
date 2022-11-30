using System;

namespace kristof_1130
{
    class Program
    {
        static void Main()
        {

            // kisebb-e mint 10

            /*
                string hs = Console.ReadLine();
                int hallgatok_szama = int.Parse(hs);
                int a = 0;

                int[] pontok = new int[hallgatok_szama];

                // 15 10 9 8 20
    
                for (int i = 0; i < hallgatok_szama; i++)
                {
                    string ps = Console.ReadLine();
                    pontok[i] = int.Parse(ps);

                    if (pontok[i] < 10)
                    {
                        a = a + 1; // a++

                    }

                }

                Console.WriteLine(a);

            

            // 1-es e



                string gs = Console.ReadLine();
                int tomb_meret = int.Parse(gs);
                int[] tomb = new int[tomb_meret];

                for (int i = 0; i < tomb_meret; i++)
                {
                    string zs = Console.ReadLine();
                    tomb[i] = int.Parse(zs);

                    if (tomb[i] == 1)
                    {   
                        Console.WriteLine("Igaz");

                    } else Console.WriteLine("Hamis");
                 }




            //minimum (pozitiv szamok)

            // 3 elemu

            // 4 2 5


                string ts = Console.ReadLine();
                int ts_meret = int.Parse(ts);
                int[] tomb_ts = new int[ts_meret];
                int minimum = 0;


                for (int i = 0; i < ts_meret; i++)
                {
                    string rs = Console.ReadLine();
                    tomb_ts[i] = int.Parse(rs);

                }

                minimum = tomb_ts[0];

                for(int i = 1; i < ts_meret; i++)
                { 

                    if (tomb_ts[i] < minimum)
                {
                    minimum = tomb_ts[i];
                }

                }

                Console.WriteLine(minimum);

                // maximum probald meg 

                */



            // 3 elemu tomb

            // 4, 5, 6
            // 5, 6, 7

            // nagyobb[0] = 4
            // 4 + 1 = 5

            // + 1


                string ws = Console.ReadLine();
                int nagyobb_meret = int.Parse(ws);
                int[] nagyobb = new int[nagyobb_meret];

                for (int i = 0; i < nagyobb_meret; i++)
                {
                    string ks = Console.ReadLine();
                    nagyobb[i] = int.Parse(ks);

                    nagyobb[i] = nagyobb[i] + 1;

                    //nagyobb[0] = 4 + 1

                }


                for(int i = 0; i < nagyobb_meret; i++)
                {
                    Console.WriteLine(nagyobb[i]);
                }






        }
    }
}

