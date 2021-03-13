using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressBar
{
    public partial class Form6 : Form
    {
        private ProgressBar[] pBary;             //
        private int[] data;                      //

        public Form6(int[] data)
        {
            this.data = data;
            pBary = new ProgressBar[data.Length];
            int vyskaPb = 10; int delkaPb = 200; int mezeraMeziPb = 10;

            for (int x = 0; x < data.Length; x++)
            {
                ProgressBar pBar = new ProgressBar();
                pBar.Location = new Point(10, 10 + x * (vyskaPb + mezeraMeziPb));
                pBar.Name = "pBar" + x;
                pBar.Size = new Size(delkaPb, vyskaPb);
                //pBar.Value = data[x];
                Controls.Add(pBar);
                pBary[x] = pBar;
            }
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(delkaPb + 20, data.Length * (vyskaPb + mezeraMeziPb) + 10);
            Name = "Form6"; Text = "Form6";




        }
        public void showData(int indexA, int indexB)
        { //
            for (int x = 0; x < data.Length; x++)
            {
                pBary[x].Value = data[x];
                //if (x == indexA)                             //
                //    pBary[x].ForeColor = Color.Red;            //
                //else if (x == indexB)                        //
                //    pBary[x].ForeColor = Color.LightGreen;     //
                //else                                         //
                //    pBary[x].ForeColor = Color.Blue;           //
                //pBary[x].Refresh();



                if (pBary[x].Value == indexB)                             //
                    pBary[x].ForeColor = Color.Red;            //
                else if (pBary[x].Value == indexA)                        //
                    pBary[x].ForeColor = Color.LightGreen;     //
                else                                         //
                    pBary[x].ForeColor = Color.Blue;           //
                pBary[x].Refresh();

            }
        }

        public void bubbleSortSimple()
        {  //
            for (int y = 0; y < data.Length - 1; y++)
            {
                for (int x = 0; x < data.Length - 1; x++)
                {
                    if (data[x] > data[x + 1])
                    {
                        int pom = data[x];
                        data[x] = data[x + 1];
                        data[x + 1] = pom;
                    }
                    this.showData(data[x], data[x + 1]);
                    System.Threading.Thread.Sleep(100);
                }
            }
        }


        public void bubbleSortSimple2()
        {  //
            bool probehlaVymena;
            do
            {
                probehlaVymena = false;
                for (int x = 0; x < data.Length - 1; x++)
                {
                    if (data[x] > data[x + 1])
                    {
                        int pom = data[x];
                        data[x] = data[x + 1];
                        data[x + 1] = pom;
                        probehlaVymena = true;
                    }

                    this.showData(data[x], data[x + 1]);
                    System.Threading.Thread.Sleep(100);
                }
            } while (probehlaVymena);

        }







    }
}
