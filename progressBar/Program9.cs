using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressBar
{
    static class Program9
    {
        private static Form7 formular1, formular2;
        private static int[] data1, data2;
        private static Thread vlakno1;          //
        private static Thread vlakno2;          //
        //public static bool ready1=false;
        //public static bool ready2=false;
        public static bool konec1=false;
        public static bool konec2=false;
        public static int index1a;
        public static int index2a;
        public static int index1b;
        public static int index2b;
        public static EventWaitHandle vl1Pripraveno = new AutoResetEvent(false); //vl1Ready
        public static EventWaitHandle vl2Pripraveno = new AutoResetEvent(false);
        public static EventWaitHandle vl1Pokracuj = new AutoResetEvent(false);   //vl1Go
        public static EventWaitHandle vl2Pokracuj = new AutoResetEvent(false);


        [STAThread]
        [Obsolete]
        static void Main()
        {
            int velikost = 15;
            data1 = new int[velikost]; data2 = new int[velikost];
            Random nahodneCislo = new Random();
            for (int x = 0; x < velikost; x++)
            {
                data1[x] = nahodneCislo.Next(0, 101);
                data2[x] = data1[x];
            }
            formular1 = new Form7(data1);
            formular2 = new Form7(data2);
            formular1.Show(); formular2.Show();
            formular1.Location = new System.Drawing.Point(10, 10);
            formular2.Location = new System.Drawing.Point(300, 10);
            formular1.showData(0, 0);
            formular2.showData(0, 0);
            // vlakna
            vlakno1 = new Thread(bubbleSortSimplex);         //
            vlakno2 = new Thread(bubbleSortOptimx);    //
            vlakno1.Start(); vlakno2.Start();         //



            while (!konec1 || !konec2)
            {
                formular1.showData(index1a, index2a);
                formular2.showData(index1b, index2b);

                if (!konec1)
                {
                    //vlakno1.Resume();          //
                    vl1Pripraveno.WaitOne();     //zde čekám na jedno hlášení o připravenosti
                }
                if (!konec2)
                {
                    //vlakno2.Resume();          //
                    vl2Pripraveno.WaitOne();     //  
                }
                vl1Pokracuj.Set(); vl2Pokracuj.Set();
                Thread.Sleep(100);

            }

            System.Threading.Thread.Sleep(1000);
        }


        private static void bubbleSortSimplex()
        {
            for (int y = 0; y < data1.Length - 1; y++)
            {

                for (int x = 0; x < data1.Length - 1; x++)
                {
                    //ready1 = false;
                    if (data1[x] > data1[x + 1])
                    {
                        int pom = data1[x];
                        data1[x] = data1[x + 1];
                        data1[x + 1] = pom;
                    }
                    //formular1.showData(x, x + 1);
                    index1a = x; index2a = x + 1;

                    System.Threading.Thread.Sleep(500);
                    //ready1 = true;
                    vl1Pripraveno.Set();
                    //vlakno1.Suspend();
                    vl1Pokracuj.WaitOne();
                }
            }
            konec1 = true;
        }

        [Obsolete]
        private static void bubbleSortOptimx()
        {
            int indexPosledniVymeny = data2.Length;
            int indexAktualniVymeny = data2.Length;
            do
            {
                indexAktualniVymeny = 0;
                for (int x = 0; x < indexPosledniVymeny - 1; x++)
                {
                    //ready2 = false;
                    if (data2[x] > data2[x + 1])
                    {
                        int pom = data2[x];
                        data2[x] = data2[x + 1];
                        data2[x + 1] = pom;
                        indexAktualniVymeny = x + 1;
                    }
                    //formular2.showData(x, x + 1);
                    index1b = x;
                    index2b = x + 1;
                    //simuluje pomalejší smyčku

                    System.Threading.Thread.Sleep(100);
                    // ready2 = true;
                    vl2Pripraveno.Set();

                    // vlakno2.Suspend();
                    vl2Pokracuj.WaitOne();
                }
                indexPosledniVymeny = indexAktualniVymeny;
            } while (indexPosledniVymeny > 0);
            konec2 = true;
        }
    }
}