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
    public partial class Form4 : Form
    {
       // private System.Windows.Forms.ProgressBar progressBar1;
        private ProgressBar progressBar;

        //private System.Windows.Forms.ProgressBar progressBar2;
        public Form4(int[] pole)
        {
            int tloustkaPb = 20; int mezeraMeziPb = 0;
            int vyska = 40;

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
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                
                //this.Controls.Add(this.progressBar2);
                //this.Controls.Add(this.progressBar1);
                this.Name = "Form3";
                this.Text = "Form3";
                this.ResumeLayout(false);


            for (int i = 0; i < 14; i++)
            {
                vyska += 25;
                mezeraMeziPb += 25;
                this.progressBar = new System.Windows.Forms.ProgressBar();
                this.progressBar.Location = new System.Drawing.Point(94, mezeraMeziPb);
                this.progressBar.Name = "progressBar"+i;
                this.progressBar.Size = new System.Drawing.Size(559, tloustkaPb);
                this.progressBar.TabIndex = i;
                this.progressBar.Value = pole[i];
                this.Controls.Add(this.progressBar);
                this.ClientSize = new System.Drawing.Size(758, vyska);
            }

    }
    }
}
