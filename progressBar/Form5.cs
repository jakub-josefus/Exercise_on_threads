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
    public partial class Form5 : Form
    {
        // private System.Windows.Forms.ProgressBar progressBar1;
        public ProgressBar progressBar = new ProgressBar();
        List<ProgressBar> listBaru = new List<ProgressBar>();


        //private System.Windows.Forms.ProgressBar progressBar2;
        public Form5(int[] pole)
        {
            //this.progressBar1 = new System.Windows.Forms.ProgressBar();
            //this.progressBar2 = new System.Windows.Forms.ProgressBar();
            //this.SuspendLayout();
            // 
            // progressBar1
            // 
            // this.progressBar1.Location = new System.Drawing.Point(94, 58);
            // this.progressBar1.Name = "progressBar1";
            //  this.progressBar1.Size = new System.Drawing.Size(559, 23);
            // this.progressBar1.TabIndex = 0;
            // 
            // progressBar2
            // 
            //this.progressBar2.Location = new System.Drawing.Point(94, 111);
            //this.progressBar2.Name = "progressBar2";
            //this.progressBar2.Size = new System.Drawing.Size(559, 23);
            //this.progressBar2.TabIndex = 1;
            // 
            // Form2
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            //this.Controls.Add(this.progressBar2);
            //this.Controls.Add(this.progressBar1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);


            for (int i = 0; i < 14; i++)
            {
                this.progressBar = new System.Windows.Forms.ProgressBar();
                this.progressBar.Value = pole[i];
                this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                listBaru.Add(this.progressBar);
            }

        }

        public void ZobrazData()
        {
            int i = 0, vyska = 0, mezeraMeziPb = 0;


            List<ProgressBar> usersByAge = listBaru.OrderBy(user => user.Value).ToList();
            foreach (var item in listBaru)
            {
                Console.WriteLine(item.Value);
            }

            Console.WriteLine("break\n");
            Console.WriteLine("break\n");

            foreach (var item in usersByAge)
            {
                Console.WriteLine(item.Value);
            }



            foreach (var item in usersByAge)
            {
                vyska += 25;
                mezeraMeziPb += 25;
                item.Location = new System.Drawing.Point(94, mezeraMeziPb);
                item.Name = "progressBar" + i;
                item.Size = new System.Drawing.Size(559, 20);
                item.TabIndex = i;
                this.ClientSize = new System.Drawing.Size(758, vyska);
                this.Controls.Add(item);
                i++;
                if (item.Value > 60)
                {
                    item.ForeColor = Color.Red;
                }

            }



        }
    }

}
